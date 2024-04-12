class Lasagna
{
    	 public int ExpectedMinutesInOven()
	 {
		 return 40;
	 }
	 public int RemainingMinutesInOven(int actualTime)
	 {
		 return ExpectedMinutesInOven() - actualTime;
	 }
	 public int PreparationTimeInMinutes(int layers)
	 {
		 return layers * 2;
	 }
	 public int ElapsedTimeInMinutes(int layers, int actual)
	 {
		 return PreparationTimeInMinutes(layers) + actual;
	 }
}d
}
