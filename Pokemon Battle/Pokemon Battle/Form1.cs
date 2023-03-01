using Pokemon_Battle.pokemons;

namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        List<character> pokemons;
        character selectedPokemon;
        character player;
        character enemy;

        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();

            pokemons = new List<character>();
            pokemons.Add(new Beedrill());
            pokemons.Add(new Lickitung()); 
            pokemons.Add(new Lechonk());
            pokemons.Add(new IronThorns());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[0];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("500");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[1];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("300");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedPokemon = pokemons[2];
            this.pictureBox1.Image = selectedPokemon.getImage();
            this.textBox1.Text = selectedPokemon.getName();
            this.textBox2.Text = ("700");
        }
    }
}