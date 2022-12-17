long MaxCt = (long)256 * 256 * 256 * 256;
for(long i = 0; i < MaxCt; i++)
    Console.WriteLine("{0}.{1}.{2}.{3}", i & 0xff, (i >> 8) & 0xff, (i >> 16) & 0xff, (i >> 24) & 0xff);

//bit shifting like this should* be faster that using the modulus operator in the Octets example, because we are not doing division.

//the expression i & 0xff is using the bitwise AND operator to mask out all but the lowest 8 bits of the i variable.
//The bitwise AND operator compares each bit of the first operand to the corresponding bit of the second operand, and if both bits are 1, the corresponding result bit is set to 1. Otherwise, the result bit is set to 0.
//"i & 0xff" is used to extract the lowest 8 bits of the i variable, which can be used as an octet (a value in the range 0-255) in an IP address.
//we are doing the same thing for the next 8 bits by telling it to do the mask to the 8 bits starting at the 8th bit "(i >> 8) & 0xff"
//and so on for the remaining.
