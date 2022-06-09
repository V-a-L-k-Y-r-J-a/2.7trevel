using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace trevel
{
    /// <summary>
    /// Логика взаимодействия для cabinet.xaml
    /// </summary>
    public partial class cabinet : Window
    {
        public cabinet()
        {
            InitializeComponent();
            User currentUser = new User();
            currentUser = Helper.userSession;
            DataContext = currentUser;
            LoadData(currentUser);
        }
        private void LoadData(User currentUser)
        {
            UserAndTask.ItemsSource = Helper.db.Tasks.Where(t => t.IdOwner == currentUser.Id).Include(s => s.IdStatusTaskNavigation).ToList();
        }
        private void LoadChangedDate()
        {
            UserAndTask.ItemsSource = Helper.db.Tasks.Where(t => t.IdOwner == Helper.userSession.Id).Include(s => s.IdStatusTaskNavigation).ToList();
        }



        private void UserAndTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task task = UserAndTask.SelectedItem as Task;
            if (task != null)
            {
                if (task.IdStatusTask == 1)
                {
                    task.IdStatusTask = 2;
                }
                else if (task.IdStatusTask == 2)
                {
                    task.IdStatusTask = 3;
                }
                else if (task.IdStatusTask == 3)
                {
                    task.IdStatusTask = 1;
                }
                Helper.db.SaveChanges();
                LoadChangedDate();
            }
            UserAndTask.SelectedItem = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new History().Show();
            this.Close();
        }

        private void ChechTask_Click(object sender, RoutedEventArgs e)
        {
            new ViewingTask().Show();
            this.Close();

        }

        private void CheckUser_Click(object sender, RoutedEventArgs e)
        {
            new ViewingUsers().Show();
            this.Close();
        }

        private void CreateReportBtn_Click(object sender, RoutedEventArgs e)
        {
            //SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.FileName = "report";
            //saveFile.Filter = "Excel files (.xlsx)|*.xlsx|Word files (.docx)|*.docx|Pdf files (.pdf)|*.pdf";
            //List<Models.Task> tasks = Helper.db.Tasks.ToList();
            //if (saveFile.ShowDialog() == true)
            //{
            //    switch (saveFile.FilterIndex)
            //    {
            //        case 1:
            //            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            //            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add();
            //            Microsoft.Office.Interop.Excel.Worksheet worksheet = app.Worksheets[1];
            //            worksheet.Name = "Задачи";
            //            worksheet.Range["A1"].Value = "Номер";
            //            worksheet.Range["B1"].Value = "Название";
            //            worksheet.Range["C1"].Value = "Описание";
            //            worksheet.Range["D1"].Value = "Дата публикации";
            //            worksheet.Range["E1"].Value = "Создатель";
            //            worksheet.Range["F1"].Value = "Исполнитель";
            //            worksheet.Range["G1"].Value = "Статус";

            //            for (int i = 0; i < tasks.Count; i++)
            //            {
            //                if (tasks[i] != null)
            //                {
            //                    worksheet.Range[$"A{i + 2}"].Value = tasks[i].TaskId;
            //                    worksheet.Range[$"B{i + 2}"].Value = tasks[i].Name;
            //                    worksheet.Range[$"C{i + 2}"].Value = tasks[i].Describtion;
            //                    worksheet.Range[$"D{i + 2}"].Value = tasks[i].PublicDate;
            //                    worksheet.Range[$"E{i + 2}"].Value = tasks[i].Creator.Login;
            //                    worksheet.Range[$"F{i + 2}"].Value = tasks[i].Acceptor.Login;
            //                    worksheet.Range[$"G{i + 2}"].Value = tasks[i].StatusTask.Name;
            //                }
            //            }
            //            workbook.SaveAs(saveFile.FileName);
            //            workbook.Close();
            //            app.Quit();
            //            break;
            //        case 2:
            //        case 3:
            //            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            //            Microsoft.Office.Interop.Word.Document document = wordApp.Documents.Add();
            //            Microsoft.Office.Interop.Word.Paragraph paragraph = document.Paragraphs.Add();
            //            Microsoft.Office.Interop.Word.Range range = paragraph.Range;
            //            Microsoft.Office.Interop.Word.Table table = document.Tables.Add(range, tasks.Count + 1, 7);
            //            Microsoft.Office.Interop.Word.Range cellRange;

            //            cellRange = table.Cell(1, 1).Range;
            //            cellRange.Text = "Номер";
            //            cellRange = table.Cell(1, 2).Range;
            //            cellRange.Text = "Название";
            //            cellRange = table.Cell(1, 3).Range;
            //            cellRange.Text = "Описание";
            //            cellRange = table.Cell(1, 4).Range;
            //            cellRange.Text = "Дата публикации";
            //            cellRange = table.Cell(1, 5).Range;
            //            cellRange.Text = "Создатель";
            //            cellRange = table.Cell(1, 6).Range;
            //            cellRange.Text = "Исполнитель";
            //            cellRange = table.Cell(1, 7).Range;
            //            cellRange.Text = "Статус";

            //            for (int i = 0; i < tasks.Count; i++)
            //            {
            //                cellRange = table.Cell(i + 2, 1).Range;
            //                cellRange.Text = tasks[i].TaskId.ToString();
            //                cellRange = table.Cell(i + 2, 2).Range;
            //                cellRange.Text = tasks[i].Name;
            //                cellRange = table.Cell(i + 2, 3).Range;
            //                cellRange.Text = tasks[i].Describtion; ;
            //                cellRange = table.Cell(i + 2, 4).Range;
            //                cellRange.Text = tasks[i].PublicDate.ToString();
            //                cellRange = table.Cell(i + 2, 5).Range;
            //                cellRange.Text = tasks[i].Creator.Login;
            //                cellRange = table.Cell(i + 2, 6).Range;
            //                cellRange.Text = tasks[i].Acceptor.Login;
            //                cellRange = table.Cell(i + 2, 7).Range;
            //                cellRange.Text = tasks[i].StatusTask.Name;

            //            }
            //            if (saveFile.FilterIndex == 2)
            //            {
            //                document.SaveAs2(saveFile.FileName);
            //            }
            //            else
            //            {
            //                document.SaveAs2(saveFile.FileName, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatPDF);
            //            }
            //            break;

            //    }
            //}
        }
    }
}
