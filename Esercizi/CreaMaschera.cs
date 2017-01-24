//Da usare se si memorizza l'IP in un variabile int
private static int CreateMask(int maskLength)
{
    if (maskLength > 32)
        throw new ArgumentOutOfRangeException("maskLength", "La maschera deve essere >= 0 e <= 32");

    int mask = maskLength == 0 ? 0 : (int)(0xffffffff << (32 - maskLength));
    return mask;
}



//da usare se si memorizza l'IP in un vettore di byte
//NOTA BENE: il byte più significativo della maschera viene 
// memorizzato nel primo byte del vettore (e viceversa)
// per modificare l'ordine di memorizzazione, è sufficiente, nell'ultima istruzione, 
// non invocare Reverese()

private static byte[] CreateMask(int maskLength)
{
    if (maskLength > 32)
        throw new ArgumentOutOfRangeException("maskLength", "La maschera deve essere >= 0 e <= 32");

    int mask = maskLength == 0 ? 0 : (int)(0xffffffff << (32 - maskLength));
    return BitConverter.GetBytes(mask).Reverse().ToArray();
}