class Calculator {
	static void Main(string arg[]) {
		int a = 10;
		int b = 6;
		
		Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a,b));
		Console.WriteLine("Hasil Pengurangan: {0} + {1} = {2}", a, b, Pengurangan(a,b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar dari program");
		Console.ReadKey();
	}
	
	static int Penambahan(int a, int b) {
		return a + b;
	}
	
	static int Pengurangan(int a, int b) {
		return a - b;
	}
}