Intel Core i7-8700K CPU 3.70GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores

| Type                           | Method         | Runtime  | Mean        | Error        | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------------------- |--------------- |--------- |------------:|-------------:|----------:|------:|--------:|----------:|------------:|
| `Benchmarks<ValueItem>`        | Array_Linq     | .NET 8.0 |  2,965.4 ns |    449.99 ns |  24.67 ns |  1.00 |    0.01 |    1296 B |        1.00 |
| `Benchmarks<ValueItem>`        | Array_Loop     | .NET 8.0 |  2,891.0 ns |     53.14 ns |   2.91 ns |  0.97 |    0.01 |    1248 B |        0.96 |
| `Benchmarks<ValueItem>`        | Generator_Linq | .NET 8.0 | 11,035.0 ns |  1,950.31 ns | 106.90 ns |  3.72 |    0.04 |    1648 B |        1.27 |
| `Benchmarks<ValueItem>`        | Generator_Loop | .NET 8.0 | 11,216.9 ns |    487.00 ns |  26.69 ns |  3.78 |    0.03 |    1592 B |        1.23 |
| `Benchmarks<ValueItem>`        | List_Linq      | .NET 8.0 |  4,242.5 ns |    392.24 ns |  21.50 ns |  1.43 |    0.01 |    1320 B |        1.02 |
| `Benchmarks<ValueItem>`        | List_Loop      | .NET 8.0 |  4,114.7 ns |  1,466.67 ns |  80.39 ns |  1.39 |    0.03 |    1248 B |        0.96 |
| `Benchmarks<BigValueItem>`     | Array_Linq     | .NET 8.0 |  6,273.6 ns |  1,424.49 ns |  78.08 ns |  2.12 |    0.03 |   66640 B |       51.42 |
| `Benchmarks<BigValueItem>`     | Array_Loop     | .NET 8.0 |  7,572.9 ns |    736.57 ns |  40.37 ns |  2.55 |    0.02 |   66528 B |       51.33 |
| `Benchmarks<BigValueItem>`     | Generator_Linq | .NET 8.0 | 16,234.0 ns |  1,171.66 ns |  64.22 ns |  5.47 |    0.04 |   67056 B |       51.74 |
| `Benchmarks<BigValueItem>`     | Generator_Loop | .NET 8.0 | 16,456.5 ns |    902.58 ns |  49.47 ns |  5.55 |    0.04 |   66936 B |       51.65 |
| `Benchmarks<BigValueItem>`     | List_Linq      | .NET 8.0 |  6,993.6 ns |    328.32 ns |  18.00 ns |  2.36 |    0.02 |   66728 B |       51.49 |
| `Benchmarks<BigValueItem>`     | List_Loop      | .NET 8.0 | 10,009.3 ns |  1,250.25 ns |  68.53 ns |  3.38 |    0.03 |   66528 B |       51.33 |
| `Benchmarks<ReferenceItem>`    | Array_Linq     | .NET 8.0 |  8,116.5 ns |    410.15 ns |  22.48 ns |  2.74 |    0.02 |    8432 B |        6.51 |
| `Benchmarks<ReferenceItem>`    | Array_Loop     | .NET 8.0 |  5,319.6 ns |    334.75 ns |  18.35 ns |  1.79 |    0.01 |    8384 B |        6.47 |
| `Benchmarks<ReferenceItem>`    | Generator_Linq | .NET 8.0 | 20,041.1 ns |  2,798.32 ns | 153.39 ns |  6.76 |    0.07 |   32792 B |       25.30 |
| `Benchmarks<ReferenceItem>`    | Generator_Loop | .NET 8.0 | 19,035.8 ns |    623.69 ns |  34.19 ns |  6.42 |    0.05 |   32736 B |       25.26 |
| `Benchmarks<ReferenceItem>`    | List_Linq      | .NET 8.0 |  8,518.5 ns |  1,645.26 ns |  90.18 ns |  2.87 |    0.03 |    8456 B |        6.52 |
| `Benchmarks<ReferenceItem>`    | List_Loop      | .NET 8.0 | 10,186.0 ns |  4,074.26 ns | 223.32 ns |  3.44 |    0.07 |    8384 B |        6.47 |
| `Benchmarks<BigReferenceItem>` | Array_Linq     | .NET 8.0 |  8,165.8 ns |    227.21 ns |  12.45 ns |  2.75 |    0.02 |    8432 B |        6.51 |
| `Benchmarks<BigReferenceItem>` | Array_Loop     | .NET 8.0 |  5,450.2 ns |    179.08 ns |   9.82 ns |  1.84 |    0.01 |    8384 B |        6.47 |
| `Benchmarks<BigReferenceItem>` | Generator_Linq | .NET 8.0 | 22,428.8 ns |    256.77 ns |  14.07 ns |  7.56 |    0.05 |   96792 B |       74.69 |
| `Benchmarks<BigReferenceItem>` | Generator_Loop | .NET 8.0 | 22,246.0 ns |  3,656.01 ns | 200.40 ns |  7.50 |    0.08 |   96736 B |       74.64 |
| `Benchmarks<BigReferenceItem>` | List_Linq      | .NET 8.0 |  8,498.9 ns |    350.86 ns |  19.23 ns |  2.87 |    0.02 |    8456 B |        6.52 |
| `Benchmarks<BigReferenceItem>` | List_Loop      | .NET 8.0 | 10,396.2 ns |  1,270.07 ns |  69.62 ns |  3.51 |    0.03 |    8384 B |        6.47 |
|                                |                |          |             |              |           |       |         |           |             |
| `Benchmarks<ValueItem>`        | Array_Linq     | .NET 9.0 |    905.6 ns |    158.52 ns |   8.69 ns |  1.00 |    0.01 |     608 B |        1.00 |
| `Benchmarks<ValueItem>`        | Array_Loop     | .NET 9.0 |    891.6 ns |    201.65 ns |  11.05 ns |  0.98 |    0.01 |    1248 B |        2.05 |
| `Benchmarks<ValueItem>`        | Generator_Linq | .NET 9.0 |  8,092.2 ns |    345.10 ns |  18.92 ns |  8.94 |    0.08 |     960 B |        1.58 |
| `Benchmarks<ValueItem>`        | Generator_Loop | .NET 9.0 |  8,345.9 ns |  2,171.91 ns | 119.05 ns |  9.22 |    0.14 |    1592 B |        2.62 |
| `Benchmarks<ValueItem>`        | List_Linq      | .NET 9.0 |    945.1 ns |    116.33 ns |   6.38 ns |  1.04 |    0.01 |     632 B |        1.04 |
| `Benchmarks<ValueItem>`        | List_Loop      | .NET 9.0 |  1,106.1 ns |    197.94 ns |  10.85 ns |  1.22 |    0.01 |    1248 B |        2.05 |
| `Benchmarks<BigValueItem>`     | Array_Linq     | .NET 9.0 |  4,533.6 ns |    274.33 ns |  15.04 ns |  5.01 |    0.04 |   32928 B |       54.16 |
| `Benchmarks<BigValueItem>`     | Array_Loop     | .NET 9.0 |  6,489.8 ns |  1,296.40 ns |  71.06 ns |  7.17 |    0.09 |   66528 B |      109.42 |
| `Benchmarks<BigValueItem>`     | Generator_Linq | .NET 9.0 | 12,188.9 ns |    481.08 ns |  26.37 ns | 13.46 |    0.11 |   33344 B |       54.84 |
| `Benchmarks<BigValueItem>`     | Generator_Loop | .NET 9.0 | 13,620.1 ns |    569.92 ns |  31.24 ns | 15.04 |    0.13 |   66936 B |      110.09 |
| `Benchmarks<BigValueItem>`     | List_Linq      | .NET 9.0 |  4,525.8 ns |    426.12 ns |  23.36 ns |  5.00 |    0.05 |   33016 B |       54.30 |
| `Benchmarks<BigValueItem>`     | List_Loop      | .NET 9.0 |  7,717.5 ns |    217.79 ns |  11.94 ns |  8.52 |    0.07 |   66528 B |      109.42 |
| `Benchmarks<ReferenceItem>`    | Array_Linq     | .NET 9.0 |  5,377.8 ns |    874.97 ns |  47.96 ns |  5.94 |    0.07 |    4136 B |        6.80 |
| `Benchmarks<ReferenceItem>`    | Array_Loop     | .NET 9.0 |  4,765.1 ns |    418.67 ns |  22.95 ns |  5.26 |    0.05 |    8384 B |       13.79 |
| `Benchmarks<ReferenceItem>`    | Generator_Linq | .NET 9.0 | 21,376.4 ns |    741.48 ns |  40.64 ns | 23.61 |    0.20 |   28496 B |       46.87 |
| `Benchmarks<ReferenceItem>`    | Generator_Loop | .NET 9.0 | 20,753.4 ns | 12,801.41 ns | 701.69 ns | 22.92 |    0.70 |   32736 B |       53.84 |
| `Benchmarks<ReferenceItem>`    | List_Linq      | .NET 9.0 |  5,230.6 ns |    610.59 ns |  33.47 ns |  5.78 |    0.06 |    4160 B |        6.84 |
| `Benchmarks<ReferenceItem>`    | List_Loop      | .NET 9.0 |  7,416.3 ns |    172.01 ns |   9.43 ns |  8.19 |    0.07 |    8384 B |       13.79 |
| `Benchmarks<BigReferenceItem>` | Array_Linq     | .NET 9.0 |  5,996.4 ns |  9,168.02 ns | 502.53 ns |  6.62 |    0.48 |    4136 B |        6.80 |
| `Benchmarks<BigReferenceItem>` | Array_Loop     | .NET 9.0 |  5,124.5 ns |  2,231.06 ns | 122.29 ns |  5.66 |    0.13 |    8384 B |       13.79 |
| `Benchmarks<BigReferenceItem>` | Generator_Linq | .NET 9.0 | 24,569.0 ns |  9,793.52 ns | 536.82 ns | 27.13 |    0.56 |   92496 B |      152.13 |
| `Benchmarks<BigReferenceItem>` | Generator_Loop | .NET 9.0 | 22,949.6 ns |  1,280.88 ns |  70.21 ns | 25.34 |    0.22 |   96736 B |      159.11 |
| `Benchmarks<BigReferenceItem>` | List_Linq      | .NET 9.0 |  5,477.6 ns |    442.16 ns |  24.24 ns |  6.05 |    0.06 |    4160 B |        6.84 |
| `Benchmarks<BigReferenceItem>` | List_Loop      | .NET 9.0 |  7,938.1 ns |  2,635.20 ns | 144.44 ns |  8.77 |    0.16 |    8384 B |       13.79 |
