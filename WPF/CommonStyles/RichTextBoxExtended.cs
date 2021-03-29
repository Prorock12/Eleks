using Prism.Commands;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;

namespace CommonUI
{
    public class RichTextBoxExtended : RichTextBox
    {
        #region dependency properties

        private static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(nameof(Text), typeof(string), typeof(RichTextBoxExtended));

        private static readonly DependencyProperty LoadProperty =
            DependencyProperty.Register(nameof(LoadCommand), typeof(ICommand), typeof(RichTextBoxExtended));

        public static readonly DependencyProperty SaveProperty = DependencyProperty.Register(
            nameof(SaveCommand), typeof(ICommand), typeof(RichTextBoxExtended));

        #endregion dependency properties

        #region properties

        public ICommand SaveCommand
        {
            get { return (ICommand)GetValue(SaveProperty); }
            set { SetValue(SaveProperty, value); }
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion properties

        public ICommand LoadCommand
        {
            get => (ICommand)GetValue(LoadProperty);
            set => SetValue(LoadProperty, value);
        }

        public RichTextBoxExtended()
        {
            SaveCommand = new DelegateCommand(Save);
            LoadCommand = new DelegateCommand(Load);
        }

        public static Stream GenerateStreamFromString(string s)
        {
            byte[] byteArray = Encoding.UTF8.GetBytes(s);
            MemoryStream stream = new MemoryStream(byteArray);
            return stream;
        }

        private void Load()
        {
            var text = "asasa";
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "RichText Files (*.rtf)|*.rtf|All files (*.*)|*.*";

            //if (ofd.ShowDialog() == true)
            //{
            TextRange doc = new TextRange(Document.ContentStart, Document.ContentEnd);

            //using(var str = new StreamReader())

            //using (var fs = GenerateStreamFromString(Text))
            //{
            //    doc.Load(fs, DataFormats.Rtf);

            //}

            var documentBytes = Encoding.UTF8.GetBytes(Text);
            using (var reader = new MemoryStream(documentBytes))
            {
                reader.Position = 0;
                doc.Load(reader, DataFormats.Rtf);
            }

            //using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open))
            //    {
            //    }
        }

        private void Save()
        {
            TextRange doc = new TextRange(Document.ContentStart, Document.ContentEnd);

            using (var fs = GenerateStreamFromString(Text))
            {
                if (fs.CanRead)
                {
                    doc.Save(fs, DataFormats.Rtf);
                }
            }
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Text Files (*.txt)|*.txt|RichText Files (*.rtf)|*.rtf|XAML Files (*.xaml)|*.xaml|All files (*.*)|*.*";
            //if (sfd.ShowDialog() == true)
            //{
            //    TextRange doc = new TextRange(docBox.Document.ContentStart, docBox.Document.ContentEnd);
            //    using (FileStream fs = File.Create(sfd.FileName))
            //    {
            //        if (Path.GetExtension(sfd.FileName).ToLower() == ".rtf")
            //            doc.Save(fs, DataFormats.Rtf);
            //        else if (Path.GetExtension(sfd.FileName).ToLower() == ".txt")
            //            doc.Save(fs, DataFormats.Text);
            //        else
            //            doc.Save(fs, DataFormats.Xaml);
            //    }
            //}
        }
    }
}