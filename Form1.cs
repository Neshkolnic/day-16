using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace день_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeFactories();
        }
        private MovieFactory _selectedFactory;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обновление выбранной фабрики в зависимости от выбранного языка 
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    _selectedFactory = new RussianMovieFactory();
                    break;
                case 1:
                    _selectedFactory = new EnglishMovieFactory();
                    break;
                case 2:
                    _selectedFactory = new FrenchMovieFactory();
                    break;
                default:
                    _selectedFactory = new RussianMovieFactory(); // По умолчанию выбираем русский язык
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie movie = _selectedFactory.CreateMovie();
            textBox1.Text = movie.Play();
        }
        private void InitializeFactories()
        {
            // Инициализация фабрик
            _selectedFactory = new RussianMovieFactory();
        }
    }
}
