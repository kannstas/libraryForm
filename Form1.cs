using MyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LibraryForm
{
    public partial class Form1 : Form

    {
        List<Item> items = new List<Item>();

        public string Author // автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
      

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Инвентарный номер
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        public string MagazineTitle // Название
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }

        public String Volume
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }

        }

        public int MagazineYear // 
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }

        public int Number
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public int MagazineInvNumber // 
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool MagazineExistence // Наличие
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public bool IfSubs
        {
            get { return checkBox4.Checked; }
            set { checkBox4.Checked = value; }
        }

        public bool MagazineSortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book(Author, Title, PublishHouse,
                Page, Year, InvNumber, Existence);
            if (ReturnTime)
            {
                book.ReturnSrok();

            }
            book.PriceBook(PeriodUse);
            items.Add(book);

            Author = Title = PublishHouse = " ";
            Page = PeriodUse = InvNumber = 1;
            Year = 1850;
            Existence = ReturnTime = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
            {
                items.Sort();
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Item item in items)
            {
                stringBuilder.Append("\n" + item.ToString());
                richTextBox1.Text = stringBuilder.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Magazine magazine = new Magazine(Volume, Number, MagazineTitle, MagazineYear,
                MagazineInvNumber, MagazineExistence, IfSubs);

      
            items.Add(magazine);

            
            Volume = MagazineTitle = " ";
            Number = MagazineInvNumber = 1;
            MagazineYear = 2015;
            MagazineExistence = false;
            IfSubs = false;

        }


        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (IfSubs)
            {
                MessageBox.Show("Подписка на журнал оформлена!");
              
            }

            
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MagazineSortInvNumber)
            {
                items.Sort();
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Item item in items)
            {
                stringBuilder.Append("\n" + item.ToString());
                richTextBox2.Text = stringBuilder.ToString();
            }
        }

    }

}
