using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Import
{
    public partial class Form1 : Form
    {
        private MemoryStream stream;
        private byte[] картинкаДляБД;

        public Form1()
        {
            InitializeComponent();
        }

        List<string> артиклиТоваров = new List<string>();
        List<string> расположенияФото = new List<string>();

        string connectionString = @"Data Source=DESKTOP-I3ASE6T\SQLEXPRESS;Initial Catalog=Pedich02;Integrated Security=True";  //Строка подключения
        private string filePath = @"C:\Users\pedic\OneDrive\Рабочий стол\Matisik-main\Сессия1\Товар_import";
        
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            connectionString = textBoxConnection.Text;
            filePath = textBoxPath.Text;
            возьмиФайлы(filePath);
            int номерФото = 0;
            foreach (string артикль in артиклиТоваров)//Для каждого товара добавляем фото
            {
                загрузиФото(артикль, номерФото);
                номерФото++;
            }
        }



        /// <summary>
        /// Добавление фото в бд
        /// </summary>
        /// <param name="артикль"></param>
        /// <param name="номерФото"></param>
        private void загрузиФото(string артикль, int номерФото)
        {
            SqlConnection подключениеБД = new SqlConnection(connectionString);
            подключениеБД.Open();
            SqlCommand комманда = подключениеБД.CreateCommand();
            Image вспомогательнаяКартинка = Image.FromFile(расположенияФото[номерФото]);
            stream = new MemoryStream();
            вспомогательнаяКартинка.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

            картинкаДляБД = stream.ToArray();
            комманда.CommandText = "Update [Product] set [ProductPhoto] = @pic where ProductArticleNumber = '" + артикль + "'";
            комманда.Parameters.AddWithValue("@pic", картинкаДляБД);
            int результатВыполнения = (int)комманда.ExecuteNonQuery();
            if (результатВыполнения != 0)
            {
                MessageBox.Show("Информация в БД обновлена успешно");
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка");
            }
            подключениеБД.Close();
        }
        /// <summary>
        /// Заполнение списка файлов и артиклей
        /// </summary>
        /// <param name="путь"></param>
        private void возьмиФайлы(string путь)
        {
            try
            {
                string[] путьПлюсШаблон = Directory.GetFiles(путь, "*.jpg");
                MessageBox.Show("Обнаружено фотографий: " + путьПлюсШаблон.Length);
                foreach (string путьФайла in путьПлюсШаблон)
                {
                    артиклиТоваров.Add(путьФайла.Substring(путь.Length+1, 6));//6 это число символов в артикле
                    расположенияФото.Add(путьФайла);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show("Ошибка: " + exeption.ToString());
            }
        }
    }
}

