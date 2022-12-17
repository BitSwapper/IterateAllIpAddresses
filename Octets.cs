long MaxCt = (long)256 * 256 * 256 * 256;
    for(long i = 0; i < MaxCt; i++)
            Console.WriteLine("{0}.{1}.{2}.{3}", i % 256, (i / 256) % 256, (i / (256 * 256)) % 256, (i / (256 * 256 * 256)) % 256);

//The modulus operator (%) is used to extract the octets of the IP address in this code by taking the remainder of i divided by a power of 256.
//For example, the expression i % 256 extracts the lowest octet of the IP address by taking the remainder of i divided by 256. 
//If i is a 32-bit integer with a value in the range 0-255, then i % 256 will simply return the value of i. 
//If i is a larger value, then i % 256 will return the remainder of i divided by 256, which will be a value in the range 0-255.
