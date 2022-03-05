using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocDameMarinIL {
	internal class BoardSquare {
		private bool isBlack;
		private bool hasRed;
		private bool hasWhite;

		public bool getIsBlack() {
			return isBlack;
		}

		public BoardSquare(bool isBlack, bool hasRed, bool hasWhite) {
			this.isBlack = isBlack;
			this.hasRed = hasRed;
			this.hasWhite = hasWhite;
		}
	}
}
