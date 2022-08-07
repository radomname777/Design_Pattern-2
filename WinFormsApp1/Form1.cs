namespace WinFormsApp1
{
    // Memento
    class CoordinateMemento
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CoordinateMemento(int x, int y)
        {
            X = x;
            Y = y;
        }
    }


    // Caretaker
    class CoordinateCaretaker
    {
        private Stack<CoordinateMemento> _memento;


        public CoordinateCaretaker()
            => _memento = new();

        public CoordinateMemento Undo()
            => _memento.Pop();


        public void Save(CoordinateMemento memento)
            => _memento.Push(memento);

    }

    class Coordinate
        {
            private int _x;
            private int _y;
            
            
            public Coordinate(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public void Increment()
            {
                _x++;
                _y++;
            }




            public void Setup(CoordinateMemento memento)
            {
                _x = memento.X;
                _y = memento.Y;
            }

            public CoordinateMemento BackUp()
                => new(_x, _y);
        }
    public partial class Form1 : Form
    {



        CoordinateCaretaker caretaker = new();


        Coordinate coordinate = new Coordinate(15, 15);
        



        public Form1()
        {
            InitializeComponent();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}