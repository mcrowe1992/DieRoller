﻿namespace DieRoller
{
	/// <summary>
	/// Represents a single six sided die (1-6)
	/// </summary>
	public class Die
	{
		private static Random _random;

		static Die()
		{
			_random = new Random();
		}

		/// <summary>
		/// Creates the dies and rolls it to 
		/// start with a random number
		/// </summary>
        public Die()
        {
			Roll();
        }

        /// <summary>
        /// The current face up value of the die
        /// </summary>
        public byte FaceValue { get; private set; }

		/// <summary>
		/// True if the die is currently held
		/// </summary>
		public bool IsHeld { get; set; }
       

        /// <summary>
		/// Rolls the die and sets the <see cref="FaceValue"/> 
		/// to the new number. Returns the new number
		/// </summary>
		/// <returns>Returns the new random number</returns>
		public byte Roll()
		{
			if (!IsHeld)
			{
				// Generate random number
		
				byte newValue = (byte)_random.Next(1, 7);

				FaceValue = newValue;
			}
			return FaceValue;
		}
    }
}
