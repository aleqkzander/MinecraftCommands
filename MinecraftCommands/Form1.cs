namespace MinecraftCommands
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Zwischenablage säubern
            Clipboard.Clear();

            // 2. Commando erstellen
            Clipboard.SetText("/give @s minecraft:command_block");
        }

        private void KnopfCreeperSpawnen_Click(object sender, EventArgs e)
        {
            // Shortcut: STRG + V = Aus der Zwischenablage einfügen

            // Das ist die Anzahl an Creep aber als Text
            string anzahlCreeperText = AnzahlCreeper.Value.ToString();

            // 1. Zwischenablage säubern

            // 2. Commando erstellen

        }
    }
}