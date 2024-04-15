using System;
using System.Windows.Forms;
using System.Xml.Linq;
namespace Gamecenter
{
  public partial class Mypr : Form
  {
    public Mypr()
    {
      InitializeComponent();
    }
    Label[,] fishka = new Label[15, 15];
    int scores = 0,lastx=0,lasty=0;
    bool effect = false, kn = true;
    
    private void Pokras(int x, int y)
    {
      int i;
      byte g = 252, b = 0, r = 0;
      if (fishka[x, y].Text != "")
      {
        i = Convert.ToInt32(fishka[x, y].Text);
        while (i > 1)
        {
            while (b < 250)
            { if (i == 1) goto proverka; else { i /= 2; b += 84; } }
            while (g > 0)
            { if (i == 1) goto proverka; else { i /= 2; g -= 84; } }
            while (r < 250)
            { if (i == 1) goto proverka; else { i /= 2; r += 84; } }
            while (b > 0)
            { if (i == 1) goto proverka; else { i /= 2; b -= 84; } }
            while (g < 250)
            { if (i == 1) goto proverka; else { i /= 2; g += 84; } }
            while (r > 0)
            { if (i == 1) goto proverka; else { i /= 2; r -= 84; } }
    /*        i /= 2;
            g -= 13;    //15,13,13
            b -= 23;    //25,28,23
            r -= 34;    //30,35,34*/
        }
        proverka: fishka[x, y].BackColor = System.Drawing.Color.FromArgb((byte)r, (byte)g, (byte)b);
      }
      else
        fishka[x, y].BackColor = System.Drawing.SystemColors.Control;
    }
    private void Dobavim()
    {
      if (effect)
      {
        Random r = new Random();
        int leight = Convert.ToInt32(Size.Value);
        while (true)
        {
          int x = r.Next(0, leight), y = r.Next(0, leight);
          if (fishka[x, y].Text == "")
          {
            int v = r.Next(1, 4);
            if (v == 2)
              fishka[x, y].Text = "4";
            else
              fishka[x, y].Text = "2";
            Pokras(x,y);
            break;
          }
        }
      }
    }

    private void Start_Click(object sender, EventArgs e)
    {
      if (Start.Text == "Resume")
      {
        for (int x = 0; x < Convert.ToInt32(Size.Value); x++)
          for (int y = 0; y < Convert.ToInt32(Size.Value); y++)
                fishka[x, y].Visible = true;
        Exit.Visible = false;
        Start.Visible = false;
        Win.Visible = false;
        Sss.Visible = false;
        Save.Visible = true;
      }
      else
      {
        if (Rb15.Checked)
        {
          StartGame();
          for (int x = 0; x < 4; x++)
            for (int y = 0; y < 4; y++)
            {
              fishka[x,y] = new Label()
              {
                AutoSize = false,
                Location = new System.Drawing.Point(125 * x, 125 * y),
                Size = new System.Drawing.Size(119, 119),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204),
                Visible = false,
                BackColor = System.Drawing.SystemColors.ActiveCaption,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
              };
              Controls.Add(fishka[x,y]);
            }
          Random r = new Random();
          int l = 0, i = 0, k;
          while (i < 16)
          {
            k = 0;
            l = r.Next(0, 16);
            for (int u = 0; u < i + 1; u++)
              if (fishka[u%4,u/4].Text == Convert.ToString(l))
                k = 1;
            if (k != 1)
            {
              fishka[i%4,i/4].Text = Convert.ToString(l);
              i++;
            }
          }
          for (i = 0; i < 16; i++)
            if (fishka[i%4,i/4].Text == "0")
            {
              fishka[i%4,i/4].Text = "";
              fishka[i%4,i/4].BackColor = System.Drawing.SystemColors.Control;
              fishka[i%4,i/4].Visible = true;
            }
            else
              fishka[i%4,i/4].Visible = true;
        }
        if (Rb48.Checked)
        {
          //if(fishka[0,0]!=null)
          StartGame();
          Save.Visible = true;
          int leight = Convert.ToInt16(Size.Value);
          SozdanieEl48(leight);
          Dobavim();
          Dobavim();
        }
        if (Rbkn.Checked)
        {
          StartGame();
          int x, y, leight = Convert.ToInt16(Size.Value);
          for (x = 0; x < leight; x++)
            for (y = 0; y < leight; y++)
            {
              fishka[x, y] = new Label
              {
                AutoSize = false,
                Location = new System.Drawing.Point(500 / leight * x, 500 / leight * y),
                Size = new System.Drawing.Size(500 / leight, 500 / leight),
                BackColor = System.Drawing.SystemColors.Control,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 212 / leight, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                BorderStyle = BorderStyle.Fixed3D,
                Enabled = false,
              };
              Controls.Add(fishka[x, y]);
            }
        }
      }
    }
    private void StartGame()
    {
      Back.Visible = true;
      Forw.Visible = false;
      Start.Visible = false;
      Win.Visible = false;
      Sss.Visible = false;
      Exit.Visible = false;
      Game.Visible = false;
      Rb15.Visible = false;
      Rb48.Visible = false;
      Rbkn.Visible = false;
      Game.Visible = false;
      Polygon.Visible = false;
      Size.Visible = false;
      Saved.Visible = false;
    }
    private void Return()
    {
      Back.Visible = false;
      Rbkn.Visible = true;
      Rb48.Visible = true;
      Rb15.Visible = true;
      Game.Visible = true;
      Start.Visible = true;
      Exit.Visible = true;
      Start.Text = "START";
      Win.Text = "You win";
    }
    
    private void End48()
    {
      Start.Text = "START";
      Start.Visible = true;
      Exit.Visible = true;
      Save.Visible = false;
      Sss.Visible = false;
      Win.Visible = false;
    }
    private void End15()
    {
      Start.Visible = true;
      Exit.Visible = true;
      Help.Visible = false;
      for (int x=0;x<4;x++)
      for (int y = 0; y <4; y++)
      {
        fishka[x,y].Visible = false;
      }
    }
    private void Endkn()
    {
      Polygon.Visible = true;
      Forw.Visible = true;
      Start.Visible = true;
      Exit.Visible = true;
      Save.Visible = false;
      Win.Visible = false;
      for (int x = 0; x < Convert.ToInt32(Size.Value); x++)
        for (int y = 0; y < Convert.ToInt32(Size.Value); y++)
          fishka[x, y].Visible = false;
    }

    private void Winkn()
    {
      Win.Visible = true;
      if (kn)
        Win.BackColor = System.Drawing.Color.FromArgb(108, 129, 215);
      else
        Win.BackColor = System.Drawing.Color.FromArgb(121, 184, 120);
      Exit.Visible = true;
      kn = true;
    }

    private void Back_KeyUp(object sender, KeyEventArgs e)
    {
      if (Rb15.Checked)
      {
        int x,y, end = 0;
        if (e.KeyValue == 87 || e.KeyValue == 38)                    //w;^
          for (x=0;x<4;x++)
            for (y=0;y<3;y++)
              if (fishka[x,y].Text == "")
                {
                  fishka[x,y].Text = fishka[x,y+1].Text;
                  fishka[x,y].BackColor = System.Drawing.SystemColors.ActiveCaption;
                  fishka[x,y+1].Text = "";
                  fishka[x,y+1].BackColor = System.Drawing.SystemColors.Control;
                  break;
                }
        if (e.KeyValue == 65 || e.KeyValue == 37)
        {

         bool nn = false;//a;<
          for (x = 0; x < 3; x++)
          {
            for (y = 0; y < 4; y++)
              if (fishka[x, y].Text == "")
              {
                fishka[x, y].Text = fishka[x + 1, y].Text;
                fishka[x, y].BackColor = System.Drawing.SystemColors.ActiveCaption;
                fishka[x + 1, y].Text = "";
                fishka[x + 1, y].BackColor = System.Drawing.SystemColors.Control;
                nn = true;
                break;
              }
            if (nn) break;
          }
        }
        if (e.KeyValue == 68 || e.KeyValue == 39)                    //d;>
          for (x=1;x<4;x++)
            for (y=0;y<4;y++)
              if (fishka[x,y].Text == "")
                {
                  fishka[x,y].Text = fishka[x-1,y].Text;
                  fishka[x,y].BackColor = System.Drawing.SystemColors.ActiveCaption;
                  fishka[x-1,y].Text = "";
                  fishka[x-1,y].BackColor = System.Drawing.SystemColors.Control;
                  break;
                }
        if (e.KeyValue == 83 || e.KeyValue == 40)                    //s;!^
          for (x=0;x<4;x++)
            for (y=1;y<4;y++)
              if (fishka[x,y].Text == "")
                {
                  fishka[x,y].Text = fishka[x,y-1].Text;
                  fishka[x,y].BackColor = System.Drawing.SystemColors.ActiveCaption;
                  fishka[x,y-1].Text = "";
                  fishka[x,y-1].BackColor = System.Drawing.SystemColors.Control;
                 break;
                }
        if (e.KeyValue == 72 && Help.TabIndex == 48)                 //help
        {
          for (x=0;x<4;x++)
            for (y=0;y<4;y++)
            {
              string Help;
              if (fishka[x,y].Text == "14" || fishka[x,y].Text == "15")
              {
                Help = fishka[x,y].Text;
                for (int k = y*4 +  x + 1; k < 16; k++)
                  if (fishka[k%4,k/4].Text == "14" || fishka[k % 4, k / 4].Text == "15")
                  {
                    fishka[x,y].Text = fishka[k % 4, k / 4].Text;
                    fishka[k % 4, k / 4].Text = Help;
                    this.Help.TabIndex = 49;
                    break;
                  }
                break;
              }
            }


        }
        for (int i = 0; i < 15; i++)                              //win??
          if (fishka[i%4,i/4].Text == Convert.ToString(i + 1))
          {
            end++;
            if (end == 12)
              Help.Visible = true;
            if (end == 15)
            {
              End15();
              Win.Text = "You Win!";
              Win.Visible = true;
              Sss.Visible = true;
            }
          }
          else
            break;
      }
      if (Rb48.Checked)
      {
        if (!Exit.Visible)
        {
          if (e.KeyValue == 87 || e.KeyValue == 38)                  //w;^
          {
            int leight = Convert.ToInt32(Size.Value);
            effect = false;
            for (int x = 0; leight > x; x++)                    //столбцы
            {
              for (int y = 0; leight > y; y++)                        //строки
              {
                int n = 0;
                while (n++ < leight - y)
                {
                  if (fishka[x, y].Text == "")                   //сдвиг если пусто
                    for (int k = y; k + 1 < leight; k++)
                    {
                      fishka[x, k].Text = fishka[x, k + 1].Text;
                      Pokras(x,k);
                    }
                  else
                    break;
                  fishka[x, leight - 1].Text = "";
                  Pokras(x,leight-1);
                  if (fishka[x, y].Text != "")
                    effect = true;
                }
                if (y - 1 >= 0 && fishka[x, y].Text == fishka[x, y - 1].Text && fishka[x, y].Text != "")              //объединение
                {
                  fishka[x, y].Text = "";
                  Pokras(x,y);
                  fishka[x, y - 1].Text = Convert.ToString(2 * Convert.ToInt32(fishka[x, y - 1].Text));
                  Pokras(x,y-1);
                  scores += Convert.ToInt16(fishka[x, y - 1].Text);
                  effect = true;
                  for (int z = y; z + 1 < leight; z++)
                  {
                    if (fishka[x, y].Text == "")
                      for (int k = y; k + 1 < leight; k++)
                      {
                        fishka[x, k].Text = fishka[x, k + 1].Text;
                        Pokras(x,k);
                      }
                    else
                      break;
                    fishka[x, leight - 1].Text = "";
                    Pokras(x,leight-1);
                  }
                }
              }
            }
            Dobavim();
          }

          if (e.KeyValue == 65 || e.KeyValue == 37)                   //a;<
          {
            int leight = Convert.ToInt32(Size.Value);
            effect = false;
            for (int y = 0; leight > y; y++)
            {
              for (int x = 0; leight > x; x++)
              {
                int n = 0;
                while (n++ < leight - x)
                {
                  if (fishka[x, y].Text == "")                   //сдвиг если пусто
                    for (int k = x; k + 1 < leight; k++)
                    {
                      fishka[k, y].Text = fishka[k + 1, y].Text;
                      Pokras(k,y);
                    }
                  else
                    break;
                  fishka[leight - 1, y].Text = "";
                  Pokras(leight-1,y);
                  if (fishka[x, y].Text != "")
                    effect = true;
                }
                if (x - 1 >= 0 && fishka[x, y].Text == fishka[x - 1, y].Text && fishka[x, y].Text != "")              //объединение
                {
                  fishka[x, y].Text = "";
                  Pokras(x,y);
                  fishka[x - 1, y].Text = Convert.ToString(2 * Convert.ToInt32(fishka[x - 1, y].Text));
                  Pokras(x-1,y);
                  scores += Convert.ToInt16(fishka[x - 1, y].Text);
                  effect = true;
                  for (int z = x; z + 1 < leight; z++)
                  {
                    if (fishka[x, y].Text == "")
                      for (int k = x; k + 1 < leight; k++)
                      {
                        fishka[k, y].Text = fishka[k + 1, y].Text;
                        Pokras(k,y);
                      }
                    else
                      break;
                    fishka[leight - 1, y].Text = "";
                    Pokras(leight-1,y);
                  }
                }
              }
            }
            Dobavim();
          }

          if (e.KeyValue == 68 || e.KeyValue == 39)                    //d;>
          {
            int leight = Convert.ToInt32(Size.Value);
            effect = false;
            for (int y = 0; leight > y; y++)                    //столбцы
            {
              for (int x = leight - 1; x > -1; x--)                        //строки
              {
                int n = 0;
                while (n++ < x)
                {
                  if (fishka[x, y].Text == "")                   //сдвиг если пусто
                    for (int k = x; k > 0; k--)
                    {
                      fishka[k, y].Text = fishka[k - 1, y].Text;
                      Pokras(k,y);
                    }
                  else
                    break;
                  fishka[0, y].Text = "";
                  Pokras(0,y);
                  if (fishka[x, y].Text != "")
                    effect = true;
                }
                if (x + 1 < leight && fishka[x, y].Text == fishka[x + 1, y].Text && fishka[x, y].Text != "")              //объединение
                {
                  fishka[x, y].Text = "";
                  Pokras(x,y);
                  fishka[x + 1, y].Text = Convert.ToString(2 * Convert.ToInt32(fishka[x + 1, y].Text));
                  Pokras(x+1,y);
                  scores += Convert.ToInt16(fishka[x + 1, y].Text);
                  effect = true;
                  for (int z = x; z > 0; z--)
                  {
                    if (fishka[x, y].Text == "")
                      for (int k = x; k > 0; k--)
                      {
                        fishka[k, y].Text = fishka[k - 1, y].Text;
                        Pokras(k,y);
                      }
                    else
                      break;
                    fishka[0, y].Text = "";
                    Pokras(0,y);
                  }
                }
              }
            }
            Dobavim();
          }

          if (e.KeyValue == 83 || e.KeyValue == 40)                    //s;!^
          {
            int leight = Convert.ToInt32(Size.Value);
            effect = false;
            for (int x = 0; leight > x; x++)                    //столбцы
            {
              for (int y = leight - 1; y > -1; y--)                        //строки
              {
                int n = 0;
                while (n++ < y)
                {
                  if (fishka[x, y].Text == "")                   //сдвиг если пусто
                    for (int k = y; k > 0; k--)
                    {
                      fishka[x, k].Text = fishka[x, k - 1].Text;
                      Pokras(x,k);
                    }
                  else
                    break;
                  fishka[x, 0].Text = "";
                  Pokras(x,0);
                  if (fishka[x, y].Text != "")
                    effect = true;
                }
                if (y + 1 < leight && fishka[x, y].Text == fishka[x, y + 1].Text && fishka[x, y].Text != "")              //объединение
                {
                  fishka[x, y].Text = "";
                  Pokras(x,y);
                  fishka[x, y + 1].Text = Convert.ToString(2 * Convert.ToInt32(fishka[x, y + 1].Text));
                  Pokras(x,y+1);
                  scores += Convert.ToInt16(fishka[x, y + 1].Text);
                  effect = true;
                  for (int z = y; z > 0; z--)
                  {
                    if (fishka[x, y].Text == "")
                      for (int k = y; k > 0; k--)
                      {
                        fishka[x, k].Text = fishka[x, k - 1].Text;
                        Pokras(x,k);
                      }
                    else
                      break;
                    fishka[x, 0].Text = "";
                    Pokras(x,0);
                  }
                }
              }
            }
            Dobavim();
          }

          for (int x = 0; x < Convert.ToInt32(Size.Value); x++)                           //победа?
            for (int y = 0; y < Convert.ToInt32(Size.Value); y++)
              if (fishka[x, y].Text != "" && Start.Text != "Resume" && Convert.ToInt32(fishka[x, y].Text) == 2048)
              {
                End48();
                Start.Text = "Resume";
                Win.Text = "You Win";
                Win.Visible = true;
                Sss.Visible = true;
                break;
              }

          bool lose = true;
          for (int x = 0; x < Convert.ToInt32(Size.Value); x++)                           //поражение?
            for (int y = 0; y < Convert.ToInt32(Size.Value); y++)
              if (fishka[x, y].Text == "" || x+1 < Convert.ToInt32(Size.Value) && fishka[x, y].Text == fishka[x + 1, y].Text || y + 1 < Convert.ToInt32(Size.Value) && fishka[x, y].Text == fishka[x, y + 1].Text)
              {
                lose = false;
                break;
              }
          if (lose)
          {
            End48();
            Win.Text = "You score " + Convert.ToString(scores);
            scores = 0;
            Win.Visible = true;
            Sss.Visible = true;
          }
        }
      }
    }
    private void Mypr_MouseClick(object sender, MouseEventArgs e)
    {
      if (Rbkn.Checked)
        if (!Exit.Visible)
        {
          int leight = Convert.ToInt16(Size.Value);
          int x = (MousePosition.X- Location.X) * leight / 500, y = (MousePosition.Y- Location.Y-32) * leight / 500;
          if (!fishka[x, y].Enabled)
            if (kn)
            {
              fishka[x, y].Text = "X";
              fishka[lastx, lasty].ForeColor = System.Drawing.Color.FromArgb(108, 129, 215);
            }
            else
            {
              fishka[x, y].Text = "O";
              fishka[lastx, lasty].ForeColor = System.Drawing.Color.FromArgb(121, 184, 120);
            }
          kn = !kn;
          fishka[x, y].Enabled = true;
          fishka[x,y].ForeColor = System.Drawing.Color.FromArgb(192,0,0);
          lastx = x; lasty = y;
          int k = x-1, n = x+1,forwin,pobeda;          //WIN???
          if (Size.Value < 4)
            forwin = 2;
          else if (Size.Value < 8)
            forwin = 3;
          else
            forwin = 4;
          pobeda = forwin;
          for (int i = 0; i < forwin; i++)                                                   //строки
            if (k > -1 && k < leight && fishka[x, y].Text == fishka[k, y].Text)
            {
              pobeda--; k--;
            }
            else if (n > -1 && n < leight && fishka[x, y].Text == fishka[n, y].Text)
            {
              pobeda--; n++;
            }
            else
              break;
          if (pobeda == 0)
          {
            Winkn();
            return;
          }
          k = y - 1; n = y + 1; pobeda = forwin;
          for (int i = 0; i < forwin; i++)                                               //столбцы
            if (k > -1 && k < leight && fishka[x, y].Text == fishka[x,k].Text)
            {
              pobeda--; k--;
            }
            else if (n > -1 && n < leight && fishka[x, y].Text == fishka[x, n].Text)
            {
              pobeda--; n++;
            }
            else
              break;
          if (pobeda == 0)
          {
            Winkn();
            return;
          }
          k = y - 1; n = y + 1; pobeda = forwin;
          for (int i = 0, w = 1, z = 1; i < forwin; i++)                                               //диагональ-левый верх
            if (k > -1 && x-w > -1 && fishka[x, y].Text == fishka[x-w, k].Text)
            {
              pobeda--; k--; w++;
            }
            else if (n < leight && x+z < leight && fishka[x, y].Text == fishka[x+z, n].Text)
            {
              pobeda--; n++; z++;
            }
            else
              break;
          if (pobeda == 0)
          {
            Winkn();
            return;
          }
          k = y - 1; n = y + 1; pobeda = forwin;
          for (int i = 0, w = 1, z = 1; i < forwin; i++)                                               //диагональ-правый верх
            if (k > -1 && x+w < leight && fishka[x, y].Text == fishka[x+w, k].Text)
            {
              pobeda--; k--; w++;
            }
            else if (n < leight && x-z>-1 && fishka[x, y].Text == fishka[x-z, n].Text)
            {
              pobeda--; n++; z++;
            }
            else
              break;
          if (pobeda == 0)
          {
            Winkn();
            return;
          }
        }
    }

    private void Back_Click(object sender, EventArgs e)
    {
      if (Rb15.Checked)
      {
        End15();
        Sss.Visible = false;
        Win.Visible = false;
        Return();
      }
      if (Rb48.Checked)
      {
        End48();
        Sss.Visible = false;
        Win.Visible = false;
        Size.Visible = true;
        Save.Visible = false;
        Saved.Visible = true;
        for (int x = 0; x < Convert.ToInt32(Size.Value); x++)
            for (int y = 0; y < Convert.ToInt32(Size.Value); y++)
                fishka[x, y].Visible = false;
        scores = 0;
        Return();
      }
      if (Rbkn.Checked)
      {
        Endkn();
        Size.Visible = true;
        Win.BackColor = System.Drawing.SystemColors.Control;
        Return();
      }
    }
    private void Exit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void Rb48_CheckedChanged(object sender, EventArgs e)
    {
      if (Rb48.Checked)
      {
        Size.Maximum = 8;
        Size.Minimum = 3;
        Size.Visible = true;
        Polygon.Visible = true;
        Saved.Visible = true;
      }
      else
      {
        Polygon.Visible = false;
        Size.Visible = false;
        Saved.Visible = false;
      }
    }
    private void Rbkn_CheckedChanged(object sender, EventArgs e)
    {
      if (Rbkn.Checked)
      {
        Size.Maximum = 15;
        Size.Minimum = 3;
        Size.Visible = true;
        Polygon.Visible = true;
        Forw.Visible = true;
        if (Size.Value < 4)
          Forw.Text = 3 + " for win";
        else if (Size.Value < 8)
          Forw.Text = 4 + " for win";
        else
          Forw.Text = 5 + " for win";
      }
      else
      {
        Polygon.Visible = false;
        Size.Visible = false;
        Forw.Visible = false;
      }
    }

    private void Save_Click(object sender, EventArgs e)
    {
      XDocument savgame = new XDocument();
      XElement element = new XElement("size", Size.Value);
      XElement kor = new XElement("kor");
      kor.Add(element);
      for (int y = 0; y < Size.Value; y++)
      {
        element = new XElement("line"+ y);
        for (int x = 0; x < Size.Value; x++)
        {
          XElement elem = new XElement("e" + x, fishka[x, y].Text);
          if (elem.Value == "")
            elem = new XElement("e" + x, 0);
          element.Add(elem);
        }
        kor.Add(element);
      }
      element = new XElement("scores", scores);
      kor.Add(element);
      savgame.Add(kor);
      savgame.Save("save.xml");
    }
    private void Saved_Click(object sender, EventArgs e)
    {
      StartGame();
      XDocument savgame = XDocument.Load("save.xml");
      Save.Visible = true;
      scores = Convert.ToInt32(savgame.Element("kor").Element("scores").Value);
      int x, y, leight = Convert.ToInt32(savgame.Element("kor").Element("size").Value);
      Size.Value = leight;
      SozdanieEl48(leight);
      for (y = 0; y < leight; y++)
      {
        x = 0;
        foreach (int el in savgame.Elements("kor").Elements("line" + y).Elements())
        {
          if (el != 0)
          {
            if (el >= 2048)
                Start.Text = "Resume";
            fishka[x, y].Text = Convert.ToString(el);
            Pokras(x++,y);
          }
          else
          {
            fishka[x, y].Text = "";
            Pokras(x++,y);
          }
        }
      }
    }

    private void Size_ValueChanged(object sender, EventArgs e)
    {
      if (Rbkn.Checked)
        if (Size.Value < 4)
          Forw.Text = 3 + " for win";
         else if (Size.Value < 8)
           Forw.Text = 4 + " for win";
          else
            Forw.Text = 5 + " for win";
    }

    private void Back_Leave(object sender, EventArgs e)
    {
      Back.Focus();
    }
    private void Mypr_MouseEnter(object sender, EventArgs e)
    {
      ClientSize = new System.Drawing.Size(494, 494);
    }

    void SozdanieEl48(int leight)
    {
        for (int x = 0; x < leight; x++)
            for (int y = 0; y < leight; y++)
            {
                fishka[x, y] = new Label
                {
                    AutoSize = false,
                    Location = new System.Drawing.Point(500 / leight * x, 500 / leight * y),
                    Size = new System.Drawing.Size(500 / leight, 500 / leight),
                    BackColor = System.Drawing.SystemColors.Control,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 50 - leight * 5, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204),
                    Text = "",
                    Visible = true
                };
                Controls.Add(fishka[x, y]);
            }
        effect = true;
    }
  }
}