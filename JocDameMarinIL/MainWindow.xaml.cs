using System.Text;
using System.Windows;


namespace JocDameMarinIL {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void btnOk_Click(object sender, RoutedEventArgs e) {
			MessageBox.Show("Hello World!"); // :(
		}

		private void menuItemNewGame_Click(object sender, RoutedEventArgs e) {
			int boardSize = 8; // Read from config | Utils.Get ....
			bool isMultipleMoveAllowed = true; // Same as before
			Game g = new Game(isMultipleMoveAllowed, boardSize);

			int numberOfBlackSquares = 0;
			foreach (BoardSquare square in g.getBoard().getSquares()) {
				if (square.getIsBlack())
					numberOfBlackSquares++; //= g.getBoard().getSquares().Count;
			}

			StringBuilder sb = new StringBuilder(string.Empty);
			sb.Append("New game! ");
			sb.Append(g.getStartTime());
			sb.Append(" | ");
			sb.Append(numberOfBlackSquares.ToString());
			sb.Append(" black squares!");
			MessageBox.Show(sb.ToString());
		}

		private void menuItemAbout_Click(object sender, RoutedEventArgs e) {
			AboutWindow wndAbout = new AboutWindow();
			wndAbout.Show();
		}
	}
}
