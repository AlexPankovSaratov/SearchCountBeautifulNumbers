using SearchCountBeautifulNumbers;

var numberSustem = 13;
int countDischarge = 13;
Console.WriteLine($"Count beautiful numbers in {numberSustem} system, with count of discharge = {countDischarge}{Environment.NewLine}" +
	$"Task answer = {SearchBeautifulNumbers.GetCountBeautifulNumbers(numberSustem, countDischarge)}");
Console.ReadKey();

