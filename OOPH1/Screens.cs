using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace OOPH1
{    
    public class MainScreen : Screen
    {
        public override string Title { get; set; }

        public MainScreen()
        {
            Title = "Kunder";
        }

        protected override void Draw()
        {
            Clear(this);
            Console.WriteLine(Title);
        }
    }

    public class TodoScreen : Screen
    {
        public override string Title { get; set; }

        public TodoScreen()
        {
            Title = "ToDo Screen";
        }

        protected override void Draw()
        {
            Clear(this);
        }
    }

    public class KillScreen : Screen
    {
        public override string Title { get; set; }
        
        public KillScreen()
        {
            Title = "Kill Screen";
        }

        protected override void Draw()
        {
            Clear(this);
        }
    }

    public class MenuScreen : Screen
    {
        public override string Title { get; set; }

        public MenuScreen()
        {
            Title = "ERP System 1.0";
        }

        protected override void Draw()
        {
            Clear(this);

            Menu menu = new Menu();
            menu.Add(new MainScreen());
            menu.Add(new TodoScreen());
            menu.Add(new KillScreen());
            menu.Start(this);
        }
    }
}