using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _120_Muistipeli
{
    public class Peli
    {
        Label label;
        Kortti kortti = new Kortti();


        public void AsetaKuviot( Form1 formi)
        {

         
            for (int sarake = 0; sarake < formi.tbpKortit.ColumnCount; sarake++)
            {
                for(int rivi = 0; rivi< formi.tbpKortit.RowCount; rivi++)
                {
                    Label lb = new Label();
                    lb.Font = new Font("Webdings", 60F);
                    lb.ForeColor = SystemColors.ButtonFace;
                    lb.Location = new Point(191*(rivi),112*(sarake) );
               //     lb.Name = "lb13";
                    lb.Size = new Size(191, 112);
                    lb.Click += formi.Kortti_Click;
                    kortti.ranNum = kortti.random.Next(0, kortti.kuviot.Count);
                    lb.Text = kortti.kuviot[kortti.ranNum];
                    kortti.kuviot.RemoveAt(kortti.ranNum);
                    formi.Controls.Add(lb);
                    formi.tbpKortit.Controls.Add(lb, rivi, sarake);
                }

            }
            
        }
        
        
        

    }
}
