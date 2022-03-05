using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocDameMarinIL {
	internal class Game {

		private DateTime startTime;
		private bool isWhiteNext;
		private Board board;

		public DateTime getStartTime() {
			return this.startTime;
		}

		public Board getBoard() {
			return this.board;
		}

		public Game(bool isMultipleMoveAllowed, int boardSize) {
			this.isWhiteNext = false;
			this.StartGame(boardSize);
		}

		private void StartGame(int boardSize) {
			this.startTime = DateTime.Now;
			this.board = new Board(boardSize);
		}
	}
}
