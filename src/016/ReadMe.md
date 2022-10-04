# Memory Address

The following explanation of converting from base 10 to base 16 is taken from [TheBook](https://programming-0101.github.io/TheBook/Topic/F/Examples/MemoryAddress.html) (used with permission).

> **Base ten** is the common number system that we use in every day life. Base ten uses the digits 0-9 and the concept of the position of a digit occupying some multiple of ten. Thus, for the number 129 there is a hundreds-position ($10^2$), a tens-position ($10^1$) and a ones-position ($10^0$).
>
> ```text
> 129 base 10
> ||\
> |\ \_ 10^0 * 9 =>   9
> | \
> \  \_ 10^2 * 2 =>  20
>  \
>   \
>    \_ 10^3 * 1 => 100
>                  ====
>                   129
> ```
>
> Converting a value from one base to another (such as base-10 to base-16) involves thinking about the digit positions of the target base. Base 16 uses the digits 0-9 along with the letters A through F for the range of hex values zero to fifteen. Each digit position in a base-16 number can hold a value of 0 to F. Thus, a digit in the ones position is worth 1 times the digit. A two-digit hex value would have the sixteens-position ($16^1$) and a ones-position ($16^0$). A three-digit hex value would add onto that a two-hundred-and-fifty-sixth-position ($16^2$). For example, to convert the number 679 base 10 to a base 16, you would follow these steps.
> 
> - Divide the original number by the two-hundred-and-fifty-sixth-position ($16^2$). Then use the remainder in calculating the next position ($16^1$). 
> - Dividing the previous steps remainder (167) by 16 gives the result of 10, which is the hex-digit of `A`.
> - The remainder of that last step is the ones-position
> - Thus, the base-10 value `679` is `2B9` in base-16.

Here's the proof:

> ```text
> 2B9 base 16
> ||\
> |\ \_ 16^0 * 9  =>    9
> | \
> \  \_ 16^2 * 11 =>  176
>  \
>   \
>    \_ 16^3 * 2  =>  512
>                    ====
>                     679 base 10
> ```

