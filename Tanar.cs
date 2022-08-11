using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace Karesz
{
    public partial class Form1 : Form
    {
        string betöltendő_pálya = "Palya_02_Mat.txt";

        void TANÁR_ROBOTJAI()
        {
            new Robot("Karesz", 0, 0, 0, 0, 10, 2, 2, 2);


            Robot janesz = new Robot("Janesz", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 29, 5, 3);

            janesz.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        janesz.Lőjj();
                        janesz.Fordulj(jobbra);
                    }
                }
            };

            Robot anti = new Robot("Anti", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 16, 4, 3);

            anti.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    for (int j = 0; j < 4; j++)
				    {
                        anti.Lőjj();
                        anti.Fordulj(jobbra);
				    }
                }
            };

            Robot mester = new Robot("Mester", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 20, 19, 0);

            mester.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    mester.Lőjj();
                    mester.Várj();
                    mester.Várj();
                    mester.Várj();
                    mester.Várj();
                    mester.Várj();
                    mester.Várj();
                    mester.Várj();
                }
            };

            Robot maestro = new Robot("Maestro", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 18, 19, 0);

            maestro.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    maestro.Lőjj();
                    maestro.Várj();
                    maestro.Várj();
                    maestro.Várj();
                    maestro.Várj();
                    maestro.Várj();
                    maestro.Várj();
                    maestro.Várj();
                }
            };

            Robot giuseppe = new Robot("Giuseppe", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 16, 19, 0);

            giuseppe.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    giuseppe.Lőjj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                    giuseppe.Várj();
                }
            };

            Robot legendario = new Robot("Legendario", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 14, 19, 0);

            legendario.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    legendario.Lőjj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                    legendario.Várj();
                }
            };

            Robot epico = new Robot("Epico", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 19, 13, 2);

            epico.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    epico.Lőjj();
                    epico.Várj();
                    epico.Várj();
                    epico.Várj();
                    epico.Várj();
                    epico.Várj();
                    epico.Várj();
                    epico.Várj();
                }
            };

            Robot matuka = new Robot("Matuka", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 17, 13, 2);

            matuka.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    matuka.Lőjj();
                    matuka.Várj();
                    matuka.Várj();
                    matuka.Várj();
                    matuka.Várj();
                    matuka.Várj();
                    matuka.Várj();
                    matuka.Várj();
                }
            };

            Robot guido = new Robot("Guido", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 15, 13, 2);

            guido.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    guido.Lőjj();
                    guido.Várj();
                    guido.Várj();
                    guido.Várj();
                    guido.Várj();
                    guido.Várj();
                    guido.Várj();
                    guido.Várj();
                }
            };

            Robot lightning = new Robot("Lightning", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 21, 26, 0);

            lightning.Feladat = delegate ()
            {
                for(int j = 0; j < 1500; j++)
                {
                    for(int i = 0; i < 4; i++)
                    {                        
                        lightning.Lőjj();
                        lightning.Fordulj(balra);
                    }
                }
            };

            Robot kobaka = new Robot("Kobaka", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 20, 27, 0);

            kobaka.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {                        
                        kobaka.Lőjj();
                        kobaka.Fordulj(balra);
                    }
                }
            };

            Robot erobeno = new Robot("Erobeno", Robot.képkészlet_lilesz, 0, 0, 0, 0, 1500, 37, 21, 3);

            erobeno.Feladat = delegate ()
            {
                for(int i = 0; i < 1500; i++)
                {
                    erobeno.Lőjj();
                    erobeno.Fordulj(balra);
                    erobeno.Lépj();
                    erobeno.Fordulj(jobbra);
                    erobeno.Lőjj();
                    erobeno.Fordulj(jobbra);
                    erobeno.Lépj();
                    erobeno.Fordulj(balra);
                }
            };
        }
    }
}