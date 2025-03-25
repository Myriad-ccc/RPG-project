using System.Windows.Forms;
using Engine;

namespace UltraAdventure
{
    public partial class UltraAdventure : Form
    {
        public UltraAdventure()
        {
            InitializeComponent();

            Player _player = new Player(100, 100, 50, 0, 1);

            Location location = new Location(1, "Home", "This is your house");

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.Experience.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
