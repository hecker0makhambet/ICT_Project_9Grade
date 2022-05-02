using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Dover1 : Form
    {
        public Dover1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stream = WindowsFormsApp1.Properties.Resources.mouse_click;
            sound.Load();
            sound.Play();
            string fio1, data1, adres1, iin1, nomer1, fio2, data2, adres2, iin2, nomer2, nomer_dog, nazv, adres3, data3, price;
            fio1 = textBox1.Text;
            data1 = textBox2.Text;
            adres1 = textBox3.Text;
            iin1 = textBox4.Text;
            nomer1 = textBox5.Text;
            fio2 = textBox6.Text;
            data2 = textBox7.Text;
            adres2 = textBox8.Text;
            iin2 = textBox9.Text;
            nomer2 = textBox10.Text;
            nomer_dog = textBox11.Text;
            nazv = textBox12.Text;
            adres3 = textBox13.Text;
            data3 = textBox14.Text;
            price = textBox15.Text;
            if(fio1 == "" || data1 == "" || adres1 == "" || iin1 == "" || nomer1 == "" || fio2 == "" || data2 == "" || adres2 == "" || iin2 == "" || nomer2 == "" || nomer_dog == "" || nazv == "" || adres3 == "" || data3 == "" || price == "")
            {
                MessageBox.Show("Вы не заполнили некоторые поля");
                return;
            }
            if(Int64.TryParse(iin1, out long result) == false || Int64.TryParse(iin2, out long result1) == false)
            {
                MessageBox.Show("ИИН должен состоять из цифр");
                return;
            }
            if (Single.TryParse(price, out float result2) == false)
            {
                MessageBox.Show("Цена должна состоять из цифр");
                return;
            }
            if(Convert.ToSingle(price) < 0)
            {
                MessageBox.Show("Цена должна быть положительным числом");
                return;
            }
            if(Int64.TryParse(nomer1, out long result3) == false || Int64.TryParse(nomer2, out long result4) == false)
            {
                MessageBox.Show("Номер уд. личности должен состоять из цифр");
                return;
            }
            if(Int64.TryParse(nomer_dog, out long result5) == false)
            {
                MessageBox.Show("Номер лицензии должен состоять из цифр");
                return;
            }
            string a;
            a = $"Я, {fio1}, {data1} года рождения, проживающий по адресу {adres1}, удостоверение личности №{nomer1}, ИИН {iin1}, доверяю {fio2}, {data2} года рождения, проживающий по адресу {adres2}, удостоверение личности №{nomer2}, ИИН {iin2}, быть моим представителем во всех учреждениях и организациях РК по вопросу приобретения в собственность на мое имя квартиры, для чего предоставляю право подавать и получать документы, расписываться за меня, оплачивать все необходимые сборы, налоги, пошлины, проводить переговоры, делать от моего имени заявления, получать необходимые справки и документы, подписывать договоры и дополнительные соглашения к ним, подписывать акты, подписывать необходимые документы с жилищными органами и получать ключи, производить оплату, а также представлять мои интересы в нотариальной конторе по вопросам регистрации права собственности, а также совершать от моего имени все действия, необходимые для выполнения этого поручения.";
            a += "\n" + $"Доверенность выдана сроком на три года без (с) права (правом) передоверия";
            a += "\n" + $"Подпись: ________________";
            a += "\n" + $"Настоящая доверенность удостоверена мною, нотариусом {nazv}";
            a += "\n" + $"№ лицензии, дата выдачи лицензии: {nomer_dog} {data3}";
            a += "\n" + $"Доверенность подписана {fio1} в моем присутствии.";
            a += "\n" + $"Личность доверителя установлена, дееспособность его проверена.";
            a += "\n" + $"Взыскаю по тарифу {price} тенге";
            a += "\n" + $"Подпись нотариуса: _________";
            Form3 form = new Form3(a);
            form.Show();
        }

        private void Dover1_Load(object sender, EventArgs e)
        {

        }
    }
}
