using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Zolotarev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        String m, k, n;
        int[] nwe = new int[9];
        int[] nwed = new int[9];
        int p1, p2, p3, p4;
        int razryad;

        private void ButtonInsertn_Click(object sender, EventArgs e)
        {
            n = nTextBox.Text;
            labelforn1.Text = n[8].ToString();
            labelforn2.Text = n[7].ToString();
            labelforn3.Text = n[6].ToString();
            labelforn4.Text = n[5].ToString();
            labelforn5.Text = n[4].ToString();
            labelforn6.Text = n[3].ToString();
            labelforn7.Text = n[2].ToString();
            labelforn8.Text = n[1].ToString();
            labelforn9.Text = n[0].ToString();
            m = labelforn3.Text + labelforn5.Text + labelforn6.Text + labelforn7.Text + labelforn9.Text;
            k = labelforn1.Text + labelforn2.Text + labelforn4.Text + labelforn8.Text;
            errorSearch();
            labelp1.Text = p1.ToString();
            labelp2.Text = p2.ToString();
            labelp3.Text = p3.ToString();
            labelp4.Text = p4.ToString();
            labelErrorPlace.Text = razryad.ToString();
            setErrorCol(razryad);
            label21.Text = p4.ToString() + p3.ToString() + p2.ToString() + p1.ToString();
            label9we.Text = nwe[0].ToString();
            label8we.Text = nwe[1].ToString();
            label7we.Text = nwe[2].ToString();
            label6we.Text = nwe[3].ToString();
            label5we.Text = nwe[4].ToString();
            label4we.Text = nwe[5].ToString();
            label3we.Text = nwe[6].ToString();
            label2we.Text = nwe[7].ToString();
            label1we.Text = nwe[8].ToString();

            setErrorCol2(razryad);
            labelfor2er1.Text = nwed[0].ToString();
            labelfor2er2.Text = nwed[1].ToString();
            labelfor2er3.Text = nwed[2].ToString();
            labelfor2er4.Text = nwed[3].ToString();
            labelfor2er5.Text = nwed[4].ToString();
            labelfor2er6.Text = nwed[5].ToString();
            labelfor2er7.Text = nwed[6].ToString();
            labelfor2er8.Text = nwed[7].ToString();
            labelfor2er9.Text = nwed[8].ToString();


            for (int i = 0; i < 9; i++)
                Console.WriteLine(nwed[i]);
            errorSearch2();
            labelforp12.Text = p1.ToString();
            labelforp22.Text = p2.ToString();
            labelforp32.Text = p3.ToString();
            labelforp42.Text = p4.ToString();


        }
        private void errorSearch()
        {
            p1 = int.Parse(k[0].ToString()) ^ int.Parse(m[0].ToString()) ^ int.Parse(m[1].ToString()) ^ int.Parse(m[3].ToString()) ^ int.Parse(m[4].ToString());
            p2 = int.Parse(k[1].ToString()) ^ int.Parse(m[0].ToString()) ^ int.Parse(m[2].ToString()) ^ int.Parse(m[3].ToString());
            p3 = int.Parse(k[2].ToString()) ^ int.Parse(m[1].ToString()) ^ int.Parse(m[2].ToString()) ^ int.Parse(m[3].ToString());
            p4 = int.Parse(k[3].ToString()) ^ int.Parse(m[4].ToString());
            toDec(p1, p2, p3, p4);
        }

        private void buttongetmac_Click(object sender, EventArgs e)
        {
            formac1.Text = GetMACAddress().ToString();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void errorSearch2()
        {
            p1 = nwed[8] ^ nwed[6] ^ nwed[4] ^ nwed[2] ^ nwed[0];
            p2 = nwed[7] ^ nwed[6] ^ nwed[3] ^ nwed[2];
            p3 = nwed[5] ^ nwed[4] ^ nwed[3] ^ nwed[2];
            p4 = nwed[1] ^ nwed[0];
            toDec(p1, p2, p3, p4);
        }

        private void setErrorCol(int i)
        {
            for (int z = 0; z < 9; z++)
                nwe[z] = int.Parse(n[z].ToString());


            if (i == 1)
            {
                Error1.Text = "Ошибка";
                if (n[8].Equals('1')) nwe[8] = 0;
                else nwe[8] = 1;
            }
            if (i == 2)
            {
                Error2.Text = "Ошибка";
                if (n[7].Equals('1')) nwe[7] = 0;
                else nwe[7] = 1;
            }
            if (i == 3)
            {
                Error3.Text = "Ошибка";
                if (n[6].Equals('1')) nwe[6] = 0;
                else nwe[6] = 1;
            }
            if (i == 4)
            {
                Error4.Text = "Ошибка";
                if (n[5].Equals('1')) nwe[5] = 0;
                else nwe[5] = 1;
            }
            if (i == 5)
            {
                Error5.Text = "Ошибка";
                if (n[4].Equals('1')) nwe[4] = 0;
                else nwe[4] = 1;
            }
            if (i == 6)
            {
                Error6.Text = "Ошибка";
                if (n[3].Equals('1')) nwe[3] = 0;
                else nwe[3] = 1;
            }
            if (i == 7)
            {
                Error7.Text = "Ошибка";
                if (n[2].Equals('1')) nwe[2] = 0;
                else nwe[2] = 1;
            }
            if (i == 8)
            {
                Error8.Text = "Ошибка";
                if (n[1].Equals('1')) nwe[1] = 0;
                else nwe[1] = 1;
            }
            if (i == 9)
            {
                Error9.Text = "Ошибка";
                if (n[0].Equals('1')) nwe[0] = 0;
                else nwe[0] = 1;
            }
        }
        private void setErrorCol2(int i)
        {
            bool far = true;
            for (int b = 0; b < 9; b++)
                nwed[b] = int.Parse(n[b].ToString());

            for (int z = 0; z < 9; z++)
            {

                if (z > 0)
                {
                    if (z == (9 - i))
                    {
                        if (nwed[z - 1] == 0)
                            nwed[z - 1] = 1;
                        else nwed[z - 1] = 0;

                    }
                }
                else
                {
                    if (z == (9 - i))
                    {
                        if (nwed[z + 1] == 0)
                            nwed[z + 1] = 1;
                        else nwed[z + 1] = 1;
                        far = false;
                    }
                }
            }

            if (i == 9)
            {
                labelerfor1.Text = "Ошибка";
                if (!far) labelerfor2.Text = "Ошибка";
            }
            if (i == 8)
            {
                labelerfor2.Text = "Ошибка";
                if (!far) labelerfor3.Text = "Ошибка";
                else labelerfor1.Text = "Ошибка";
            }
            if (i == 7)
            {
                labelerfor3.Text = "Ошибка";
                if (!far) labelerfor4.Text = "Ошибка";
                else labelerfor2.Text = "Ошибка";
            }
            if (i == 6)
            {
                labelerfor4.Text = "Ошибка";
                if (!far) labelerfor5.Text = "Ошибка";
                else labelerfor3.Text = "Ошибка";
            }
            if (i == 5)
            {
                labelerfor5.Text = "Ошибка";
                if (!far) labelerfor6.Text = "Ошибка";
                else labelerfor4.Text = "Ошибка";
            }
            if (i == 4)
            {
                labelerfor6.Text = "Ошибка";
                if (!far) labelerfor7.Text = "Ошибка";
                else labelerfor5.Text = "Ошибка";
            }
            if (i == 3)
            {
                labelerfor7.Text = "Ошибка";
                if (!far) labelerfor8.Text = "Ошибка";
                else labelerfor6.Text = "Ошибка";
            }
            if (i == 2)
            {
                labelerfor8.Text = "Ошибка";
                if (!far) labelerfor9.Text = "Ошибка";
                else labelerfor7.Text = "Ошибка";
            }
            if (i == 1)
            {
                labelerfor9.Text = "Ошибка";
                labelerfor8.Text = "Ошибка";
            }
        }
        private void toDec(int p1, int p2, int p3, int p4)
        {
            razryad = p1 * 1 + p2 * 2 + p3 * 4 + p4 * 8;
        }
        public string GetMACAddress()
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            String sMacAddress = string.Empty;

            foreach (NetworkInterface adapter in nics)
            {
                if (sMacAddress == String.Empty)// only return MAC Address from first card  
                {
                    IPInterfaceProperties properties = adapter.GetIPProperties();
                    sMacAddress = adapter.GetPhysicalAddress().ToString();

                }
            }
            return sMacAddress;
        }
    }
}
