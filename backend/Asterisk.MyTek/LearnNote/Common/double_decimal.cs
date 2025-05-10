/*
 * double and decimal are both data types used to represent floating-point numbers, which are numbers with fractional parts.
 * double 
    * Typically uses 64 bits (8 bytes) of memory.
    * Has a larger range than decimal.
    * Offers high performance for mathematical calculations.
    * Prone to rounding errors(dễ mắc lỗi làm tròn) when representing decimal fractions(khi biểu diễn số thập phân).
    * 
 * decimal 
    * it's generally larger than double, in .NET it uses 128 bits (16 bytes).
    * Has a smaller range than double.
    * Provides high precision and accuracy for decimal values. It can represent decimal fractions exactly,
avoiding the rounding errors inherent in binary floating-point types.

Imagine you're measuring a piece of wood with two different rulers:
    - double is like a ruler with very fine but not perfectly precise markings.
You can measure very long pieces, and it's quick to use, but your measurements might be slightly off for certain lengths.
    - decimal is like a ruler with perfectly precise markings for all common decimal lengths.
It might be a bit bulkier(cồng kềnh) and slower to use for very long pieces,
but for the lengths it can measure, your measurements will be exact.
 */