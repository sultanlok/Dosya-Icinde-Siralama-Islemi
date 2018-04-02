using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  }

        
        
        private void button1_Click_1(object sender, EventArgs e)
        {// dosya oluştur
            StreamWriter dosya = File.CreateText(@"d:\\dosya.docx");
            dosya.Close();
            MessageBox.Show("Dosya oluşturuldu.");
        }

        private void button2_Click(object sender, EventArgs e)
        { //dosyaya yaz
             StreamWriter yaz = new StreamWriter(@"d:\\dosya.docx");
            yaz.WriteLine(textBox1.Text);
            MessageBox.Show("Yazma işlemi başarılı.");
              yaz.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        { //dosya içeriğini göster
            StreamReader oku = File.OpenText(@"d:\\dosya.docx");
            listBox1.Items.Add(oku.ReadLine());
            oku.Close();
            MessageBox.Show("Dosya içeriği.");
        }

        private void button4_Click(object sender, EventArgs e)
        { // dosya içeriğini sırala
           
                StreamReader sırala = File.OpenText(@"d:\\dosya.docx");
                string metin = sırala.ReadLine();
                string[] dizi = metin.Split(' ');
                int []arr=new int[dizi.Length];
                int index=0,terim;
                for (int i = 0; i < dizi.Length; i++)
                {
                    string ata = dizi[i];
                    terim = int.Parse(ata);
                    arr[index] = terim;
                   
                       index++;
                }
                Array.Sort(arr);
                for (int j = 0; j < arr.Length; j++)
                {
                    listBox2.Items.Add(arr[j] + "\n");
                } 
            MessageBox.Show("Sıralama yapıldı.");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {//dosya yaz a karakter girilmesini engelle. Sadece sayı girilmesini sağla
            e.Handled = char.IsLetter(e.KeyChar);
        }
               
        }
    }

