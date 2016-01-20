# NumbersToText
Converts numbers, including decimals, into English text or legal text (text followed by US currency). 
Inlcudes options for decimal and integral fractions.

There are 3 public methods:

public static string ConvertToText(decimal number, bool ignoreDecimal = true, int decimalLength = 2, bool decimalFraction = true)
    This method converts any number, including decimals, to a text representation.
    If ignoreDecimal is set to false, then the decimal portion is converted.  Otherwise, just the integer portion is converted.
    decimalLength is set as the "magnitude" of the decimal portion--how many decimal places to convert.
    decimalLength currently only accepts values up to 4 (ten-thousandths)
    decimalFraction: if true, convert into tenths, hundredths, etc, according to the value of decimalLength.
                     If false, try to convert the fraction into an "integral" fraction, i.e., 1/2, 3/16, etc.  If this
                     not possible, convert the number to a decimal fraction.  This only works on "regular" fractions: 
                     .3333333 does not convert to 1/3
 sample output:
100				                one hundred
65333				            sixty-five thousand three hundred thirty-three
12.354 (1 decimal point)	    twelve and three-tenths
12.354	(3 decimal points)	    twelve and three hundred fifty-four thousandths
12.354 (4 decimal points)	    twelve and three thousand five hundred forty ten-thousandths
4001003456.2			        four billion one million three thousand four hundred fifty-six and two-tenths
4.125	as decimal fraction	    four and one hundred twenty-five thousandths	
4.125 as integral fraction	    four and one-eighth
                     
                     
                     
public static string ConvertToCurrency(decimal number, bool ignoreCents = false, int decimalLength =2)
    This method converts a number into U.S. currency.  It does nothing really magical.
    if ignoreCents is true, then only the dollar portion is displayed.  (This feature is used by the ConvertNumberToLegalText
    method for amounts above $100).
    decimalLength is set to the number of decimal places the text should return.
    
    sample output:
    .22				    $0.22
    33467.287			$33,467.28
    
  
public static string ConvertToLegalDollarText(decimal number, int decimalLength = 2, bool decimalFraction = true)
    This method converts a number into text followed by U.S. currency in parentheses.
    If the amount is greater than $100, cents are ignored.  This aspect might be better off as a bool parameter.
    
    sample output:
    86.235				eighty-six dollars twenty-three cents ($86.23)
    456962 			    four hundred fifty-six thousand nine hundred sixty-two dollars ($456,962)
