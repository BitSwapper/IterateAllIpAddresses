long MaxCt = (long)256 * 256 * 256 * 256;
for(long i = 0; i < MaxCt; i++)
{
    int octet1 = (int)(i & 0xff);
    int octet2 = (int)((i >> 8) & 0xff);
    int octet3 = (int)((i >> 16) & 0xff);
    int octet4 = (int)((i >> 24) & 0xff);
    Console.WriteLine("{0}.{1}.{2}.{3}", octet1, octet2, octet3, octet4);
}
//bit shifting like this should* be faster that using the modulus operator in the Octets example
