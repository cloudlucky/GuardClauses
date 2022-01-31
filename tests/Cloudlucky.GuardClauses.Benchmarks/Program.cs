var DefaultConfiguration =
            DefaultConfig
               .Instance
               .AddDiagnoser(MemoryDiagnoser.Default)
               .AddColumn(BenchmarkDotNet.Columns.RankColumn.Arabic)
               .AddColumn(BenchmarkDotNet.Columns.StatisticColumn.Median);

BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, DefaultConfiguration);