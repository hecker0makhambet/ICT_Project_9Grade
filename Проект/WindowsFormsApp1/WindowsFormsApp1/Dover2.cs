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
    public partial class Dover2 : Form
    {
        public Dover2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer();
            sound.Stream = WindowsFormsApp1.Properties.Resources.mouse_click;
            sound.Load();
            sound.Play();
            string fio1, fio2, fio3, fio4, data1, data2, data3, data4, adres1, adres2, adres4, obl1, obl2, obl3, iin1, iin2, iin3, nomer3, nomer4, nazv, price;
            fio1 = textBox1.Text;
            data1 = textBox2.Text;
            adres1 = textBox3.Text;
            iin1 = textBox4.Text;
            obl1 = textBox5.Text;
            fio2 = textBox6.Text;
            data2 = textBox7.Text;
            adres2 = textBox8.Text;
            iin2 = textBox9.Text;
            obl2 = textBox10.Text;
            fio3 = textBox11.Text;
            data3 = textBox12.Text;
            obl3 = textBox13.Text;
            iin3 = textBox14.Text;
            nomer3 = textBox15.Text;
            fio4 = textBox16.Text;
            nazv = textBox17.Text;
            adres4 = textBox18.Text;
            nomer4 = textBox19.Text;
            price = textBox20.Text;
            data4 = textBox21.Text;
            if (fio1 == "" || fio2 == "" || fio3 == "" || fio4 == "" || data1 == "" || data2 == "" || data3 == "" || data4 == "" || adres1 == "" || adres2 == "" || adres4 == "" || obl1 == "" || obl2 == "" || obl3 == "" || iin1 == "" || iin2 == "" || iin3 == "" || nomer3 == "" || nomer4 == "" || nazv == "" || price == "" )
            {
                MessageBox.Show("Вы не заполнили некоторые поля");
                return;
            }
            if (Int64.TryParse(iin1, out long result) == false || Int64.TryParse(iin2, out long result1) == false || Int64.TryParse(iin3, out long result2) == false)
            {
                MessageBox.Show("ИИН должен состоять из цифр");
                return;
            }
            if(Int64.TryParse(nomer3, out long result3) == false)
            {
                MessageBox.Show("Номер свидетельства о рождении должен состоять из цифр");
                return;
            }
            if (Int64.TryParse(nomer4, out long result4) == false)
            {
                MessageBox.Show("Номер договора должен состоять из цифр");
                return;
            }
            if (Single.TryParse(price, out float result5) == false)
            {
                MessageBox.Show("Цена должна быть цифрой");
                return;
            }
            if (Convert.ToSingle(price) < 0)
            {
                MessageBox.Show("Цена должна быть положительным числом");
                return;
            }
            string a;
            a = $"Я, {fio1}, {data1} года рождения, уроженец {obl1}, проживающий по адресу {adres1}, ИИН {iin1}, доверяю {fio2}, {data2} года рождения, проживающий по адресу {adres2}, уроженец {obl2}, ИИН {iin2}, сопровождать моего ребенка - {fio3}, {data3} года рождения, уроженец {obl3}, ИИН {iin3}, свидетельство о рождении {nomer3} в поездках по всей территории РК и РФ автомобильным, железнодорожным транспортом, для чего предоставляю ему на представление моих интересов и интересов моего сына перед всеми компетентными органами РК и РФ, в том числе органах пограничного контроля, в органах МВД, в медицинских учреждениях, в органах образования РК, нести ответственность за жизнь и за здоровье моего ребенка и принимать решения по защите его прав и законных интересов, приобретать билеты, подавать от моего имени заявления, документы, расписываться за меня в документах, составлять иные документы, выполнять все действия, связанные с данным поручением.";
            a += "\n" + $"Доверенность выдана сроком на один год";
            a += "\n" + $"Подпись: ________________";
            a += "\n" + $"{data4} настоящая доверенность удостоверена мною, {fio4}, нотариусом {nazv}";
            a += "\n" + $"Доверенность подписана {fio1} в моем присутствии.";
            a += "\n" + $"Личность доверителя установлена, дееспособность его проверена.";
            a += "\n" + $"Зарегистрировано в реестре за №{nomer4}";
            a += "\n" + $"Взыскаю по тарифу {price} тенге";
            a += "\n" + $"Подпись нотариуса: _________";
            Form3 form = new Form3(a);
            form.Show();
        }

        private void Dover2_Load(object sender, EventArgs e)
        {

        }
    }
}
