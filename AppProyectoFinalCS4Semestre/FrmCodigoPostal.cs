using System;
using System.Diagnostics;
using DocumentFormat.OpenXml;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Row = DocumentFormat.OpenXml.Spreadsheet.Row;
using Cell = DocumentFormat.OpenXml.Spreadsheet.Cell;
using DocumentFormat.OpenXml.Wordprocessing;
using Paragraph = DocumentFormat.OpenXml.Wordprocessing.Paragraph;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;
using Document = iTextSharp.text.Document;
using Table = DocumentFormat.OpenXml.Wordprocessing.Table;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
namespace AppProyectoFinalCS4Semestre
{
    public partial class FrmCodigoPostal : Form
    {
        bool maximizado;
        public FrmCodigoPostal()
        {
            InitializeComponent();
            LVDatos.View = System.Windows.Forms.View.Details;
            maximizado = false;
        }

        private void BtnAbrir_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            LVDatos.Clear();
            string rutaArchivo = dialogo.FileName;
            StreamReader sr = new StreamReader(rutaArchivo, Encoding.GetEncoding(1252));
            string columnas = sr.ReadLine();
            string[] columna = columnas.Split('|');
            for (int i = 0; i < columna.Length; i++)
            {
                LVDatos.Columns.Add(columna[i]);
            }

            string renglon;
            Dictionary<string, int> contadorCodigosPostales = new Dictionary<string, int>();
            Dictionary<string, Dictionary<string, List<string>>> datosCodigosPostales = new Dictionary<string, Dictionary<string, List<string>>>();

            while ((renglon = sr.ReadLine()) != null)
            {
                string[] datos = renglon.Split('|', '<', '>');
                ListViewItem item = new ListViewItem(datos[0]);
                for (int i = 1; i < datos.Length; i++)
                {
                    item.SubItems.Add(datos[i]);
                }
                LVDatos.Items.Add(item);

                string codigoPostal = datos[0];
                string colonia = datos[1];
                string ciudad = datos[5];

                // Agregar el código postal al TreeView si no está presente
                if (!datosCodigosPostales.ContainsKey(codigoPostal))
                {
                    datosCodigosPostales.Add(codigoPostal, new Dictionary<string, List<string>>());
                }

                // Agregar la colonia a la lista de colonias del código postal si no está presente
                if (!datosCodigosPostales[codigoPostal].ContainsKey(colonia))
                {
                    datosCodigosPostales[codigoPostal].Add(colonia, new List<string>());
                }

                // Agregar la ciudad a la lista de ciudades del código postal si no está presente
                if (!datosCodigosPostales[codigoPostal][colonia].Contains(ciudad))
                {
                    datosCodigosPostales[codigoPostal][colonia].Add(ciudad);
                }

                // Contar el número de apariciones de cada código postal
                if (contadorCodigosPostales.ContainsKey(codigoPostal))
                {
                    contadorCodigosPostales[codigoPostal]++;
                }
                else
                {
                    contadorCodigosPostales[codigoPostal] = 1;
                }
            }

            sr.Close();

            // Limpiar el TreeView
            TVDatos.Nodes.Clear();

            // Agregar los códigos postales, colonias y ciudades al TreeView
            foreach (var codigoPostal in datosCodigosPostales)
            {
                TreeNode nodoCodigoPostal = TVDatos.Nodes.Add(codigoPostal.Key);

                foreach (var colonia in codigoPostal.Value)
                {
                    TreeNode nodoColonia = nodoCodigoPostal.Nodes.Add(colonia.Key);

                    foreach (var ciudad in colonia.Value)
                    {
                        nodoColonia.Nodes.Add(ciudad);
                    }
                }
            }
            Chart1.Series[0].Points.Clear();
            foreach (var codigoPostal in contadorCodigosPostales)
            {
                Chart1.Series[0].Points.AddXY(codigoPostal.Key, codigoPostal.Value);
            }

        }

        private void BtnGuardarOpenXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (.xlsx)|.xlsx|All files (.)|.";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            if (sfd.FileName != "")
            {
                SpreadsheetDocument document = SpreadsheetDocument.Create(sfd.FileName, SpreadsheetDocumentType.Workbook);
                // Agregar una hoja de trabajo
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet(new SheetData());
                DocumentFormat.OpenXml.Spreadsheet.Sheets sheets = workbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "ListView" };
                sheets.Append(sheet);

                // Obtener la colección de celdas
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Recorrer las columnas y filas de la ListView
                for (int i = 0; i < LVDatos.Columns.Count; i++)
                {
                    // Crear una fila para los encabezados
                    if (i == 0)
                    {
                        Row row = new Row() { RowIndex = 1 };
                        sheetData.Append(row);
                    }
                    // Obtener el encabezado de la columna
                    string headerText = LVDatos.Columns[i].Text;
                    // Crear una celda para el encabezado
                    Cell headerCell = new Cell()
                    {
                        CellReference = GetColumnName(i + 1) + "1",
                        DataType = CellValues.String,
                        CellValue = new CellValue(headerText)
                    };
                    // Agregar la celda al final de la fila
                    Row headerRow = (Row)sheetData.ChildElements.GetItem(0);
                    headerRow.AppendChild(headerCell);

                    // Recorrer las filas de la columna
                    for (int j = 0; j < LVDatos.Items.Count; j++)
                    {
                        // Crear una fila para los datos
                        if (i == 0)
                        {
                            Row row = new Row() { RowIndex = (uint)(j + 2) };
                            sheetData.Append(row);
                        }
                        // Obtener el valor del dato
                        string dataText = LVDatos.Items[j].SubItems[i].Text;
                        // Crear una celda para el dato
                        Cell dataCell = new Cell()
                        {
                            CellReference = GetColumnName(i + 1) + (j + 2),
                            DataType = CellValues.String,
                            CellValue = new CellValue(dataText)
                        };
                        // Agregar la celda al final de la fila
                        Row dataRow = (Row)sheetData.ChildElements.GetItem(j + 1);
                        dataRow.AppendChild(dataCell);
                    }
                }
                // Guardar y cerrar el documento
                workbookPart.Workbook.Save();
                document.Close();
                Process.Start(sfd.FileName);
            }
        }
        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardarConInterop_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea una instancia de la aplicación Excel
                var excelApp = new Microsoft.Office.Interop.Excel.Application();

                // Crea un nuevo libro de Excel
                var workbook = excelApp.Workbooks.Add();

                // Crea una hoja de Excel
                var worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];

                // Exporta el contenido del ListView a la hoja de Excel
                for (int i = 0; i < LVDatos.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = LVDatos.Columns[i].Text;
                }

                for (int i = 0; i < LVDatos.Items.Count; i++)
                {
                    for (int j = 0; j < LVDatos.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = LVDatos.Items[i].SubItems[j].Text;
                    }
                }
                // Guarda el archivo de Excel
                workbook.SaveAs(saveFileDialog.FileName);

                // Cierra el archivo y la aplicación Excel
                workbook.Close();
                excelApp.Quit();
            }
        }

        private void BtnGuardarCSV_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener el carácter de separación ingresado por el usuario
                char separador = ObtenerCaracterSeparador();

                // Crear el contenido CSV a partir de los datos del ListView
                StringBuilder contenidoCSV = new StringBuilder();

                // Agregar los encabezados de columna al contenido CSV
                for (int i = 0; i < LVDatos.Columns.Count; i++)
                {
                    contenidoCSV.Append(LVDatos.Columns[i].Text);
                    if (i < LVDatos.Columns.Count - 1)
                    {
                        contenidoCSV.Append(separador);
                    }
                }
                contenidoCSV.AppendLine();

                // Agregar los datos de las filas al contenido CSV
                foreach (ListViewItem item in LVDatos.Items)
                {
                    for (int i = 0; i < item.SubItems.Count; i++)
                    {
                        contenidoCSV.Append(item.SubItems[i].Text);
                        if (i < item.SubItems.Count - 1)
                        {
                            contenidoCSV.Append(separador);
                        }
                    }
                    contenidoCSV.AppendLine();
                }

                // Guardar el contenido CSV en el archivo
                File.WriteAllText(saveFileDialog.FileName, contenidoCSV.ToString());

                // Mostrar un mensaje de éxito al usuario
                MessageBox.Show("Archivo guardado exitosamente.", "Guardar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private char ObtenerCaracterSeparador()
        {
            if (!string.IsNullOrWhiteSpace(txtCaracterSeparador.Text))
            {
                return txtCaracterSeparador.Text[0];
            }
            else
            {
                return ',';
            }
        }
        private void BtnGuardarPDF_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Código para guardar en PDF utilizando una biblioteca de terceros como iTextSharp o PDFSharp.
                // Asegúrate de agregar la referencia y los using necesarios para la biblioteca de tu elección.
                // Aquí se muestra un ejemplo utilizando iTextSharp:

                // Crea un nuevo documento PDF
                Document document = new Document();

                // Crea un escritor PDF para el documento y lo vincula al archivo de destino
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));

                // Abre el documento para escritura
                document.Open();

                // Agrega el contenido del ListView al documento PDF
                PdfPTable table = new PdfPTable(LVDatos.Columns.Count);

                // Agrega los encabezados de columna al documento
                foreach (ColumnHeader column in LVDatos.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                    table.AddCell(cell);
                }
                // Agrega los datos de las filas al documento
                foreach (ListViewItem item in LVDatos.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(subItem.Text));
                        table.AddCell(cell);
                    }
                }

                // Agrega la tabla al documento
                document.Add(table);

                // Cierra el documento
                document.Close();

                // Abre el archivo PDF resultante
                Process.Start(saveFileDialog.FileName);
            }
        }
        private string GetColumnName(int index)
        {
            int dividend = index;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }
            return columnName;
        }
        private void BtnGuardarWord_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Word (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Crea un nuevo documento de Word
                Document document = new Document();

                // Crea un escritor de Word para el documento y lo vincula al archivo de destino
                using (var writer = WordprocessingDocument.Create(saveFileDialog.FileName, WordprocessingDocumentType.Document))
                {
                    // Agrega un cuerpo al documento
                    MainDocumentPart mainPart = writer.AddMainDocumentPart();
                    mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    // Crea una tabla
                    Table table = new Table();

                    // Crea la primera fila como encabezados de columna
                    TableRow headerRow = new TableRow();
                    foreach (ColumnHeader column in LVDatos.Columns)
                    {
                        TableCell headerCell = new TableCell(new Paragraph(new Run(new Text(column.Text))));
                        headerRow.Append(headerCell);
                    }
                    table.Append(headerRow);

                    // Agrega los datos de las filas al documento
                    foreach (ListViewItem item in LVDatos.Items)
                    {
                        TableRow dataRow = new TableRow();
                        foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                        {
                            TableCell dataCell = new TableCell(new Paragraph(new Run(new Text(subItem.Text))));
                            dataRow.Append(dataCell);
                        }
                        table.Append(dataRow);
                    }

                    // Agrega la tabla al cuerpo del documento
                    body.Append(table);
                }

                // Abre el archivo de Word resultante
                Process.Start(saveFileDialog.FileName);
            }
        }

        private void Chart1_Click_1(object sender, EventArgs e)
        {

            if (maximizado)
            {
                Chart1.Location = new System.Drawing.Point(436, 12);
                Chart1.Height = 240; Chart1.Width = 320;
                TVDatos.Visible = true;
                BtnAbrir.Visible = true;
            }
            else
            {
                Chart1.Location = new System.Drawing.Point(0, 0);
                Chart1.Height = this.Height; Chart1.Width = this.Width;
                TVDatos.Visible = false;
                BtnAbrir.Visible = false;
            }
            maximizado = !maximizado;
        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            {
                Chart1.Series.Clear();
            }
        }
    }
}
