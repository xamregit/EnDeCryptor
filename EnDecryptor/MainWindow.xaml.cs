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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EnDeCryptor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Caesar caesar;
        public Atbasch atbasch;
        public MainWindow()
        {
            InitializeComponent();
            caesar = new Caesar(3);
            atbasch = new Atbasch();
        }

        private void EncryptButton_Click(object sender, RoutedEventArgs e)
        {
            switch(CyphersList.SelectedIndex)
            {
                case 0:
                    Encrypted.Text = caesar.Encrypt(OriginalText.Text.ToCharArray());
                    break;
                case 1:
                    Encrypted.Text = atbasch.Encrypt(OriginalText.Text.ToCharArray());
                    break;
                default:
                    break;
            }
                   
        }

        private void DecryptButton_Click(object sender, RoutedEventArgs e)
        {
            switch (CyphersList.SelectedIndex)
            {
                case 0:
                    Decrypted.Text = caesar.Decrypt(Encrypted.Text.ToCharArray());
                    break;
                case 1:
                    Decrypted.Text = atbasch.Decrypt(Encrypted.Text.ToCharArray());
                    break;
                default:
                    break;
            }
           
        }
    }
}
