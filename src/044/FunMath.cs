public class FunMath
{
    // PrimeNumber is the "payload" data type for the event
    public record PrimeNumber(ulong Number, int Position);
    // FoundPrime is the name of the event
    public event EventHandler<PrimeNumber> FoundPrime;
    // RaiseFoundPrimeEvent notifies all subscribers
    private void RaiseFoundPrimeEvent(PrimeNumber info)
    {
        if(FoundPrime != null)
            FoundPrime.Invoke(this, info);
    }

    public void FindPrimeNumbers()
    {
        // A prime number is a number that is divisible only by itself and 1.
        // Prime numbers start at the number 2
        // I'll be using the ulong data type to get the largest possible prime numbers
        int position = 1;
        for(ulong num = 2; num < ulong.MaxValue; num++)
        {
            bool isPrime = true;
            ulong midway = (ulong) Math.Sqrt(num);
            for(ulong divisor = 2; divisor <= midway; divisor++)
            {
                if(num % divisor == 0)
                {
                    isPrime = false;
                }
            }
            if(isPrime)
            {
                // here is where I will invoke my event
                RaiseFoundPrimeEvent(new(num, position));
                position++; // for the next time I find one
            }
        }
    }
}