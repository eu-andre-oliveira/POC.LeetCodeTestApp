using System.Diagnostics;

namespace POC.LeetCodeTestApp.challenges
{
    public static class TwoSumChallenge
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            //var stopwatch = Stopwatch.StartNew();
            //criar um array bidimensional com os indices e os valores
            //ordenar por valores


            //long time1 = stopwatch.ElapsedMilliseconds;
            //Console.WriteLine($"Tempo de execução da abordagem com Select: {time1} ms");


            GC.Collect();
            GC.WaitForPendingFinalizers();
                        
            int[,] numeroComIndice2 = new int[nums.Length, 2];
            // Preenche o array bidimensional com índices e valores
            for (int i = 0; i < nums.Length; i++)
            {
                numeroComIndice2[i, 0] = i;       // índice
                numeroComIndice2[i, 1] = nums[i]; // valor
            }

            Array.Sort(nums);

            //var teste = numeroComIndice2.();
            for (int i = 0; i < nums.Length; i++)
            {
                int targetElement2 = nums[i] - target;

                for (int j = 1; j < nums.Length; j++)
                {
                    if (j == i) continue;

                    if (targetElement2 == numeroComIndice2[1,j])
                      return [targetElement2];
                }

                numeroComIndice2[i, 0] = i;       // índice
                numeroComIndice2[i, 1] = nums[i]; // valor
            }



            //ordenar por valores
            //var tempArray = new int[nums.Length, 2];
            //Array.Copy(numeroComIndice2, tempArray, numeroComIndice2.Length);
            //Array.Sort(tempArray, (a, b) => a[1].CompareTo(b[1]));




            return [];
            //ordenar por valores

            //rodar loop com o menor valor crescendo

            //calcular se target - valor n 

            //procurar na lista se tem esse numero

            //se encontrar retorna os indices


            var numeroComIndice = nums.Select((value, x) => new { indice = x, valor = value }).OrderBy(x => x.valor).ToArray();
            for (int i = 0; i < numeroComIndice.Length; i++)
            {
                var targetElement = numeroComIndice
                    .Where(x => x.valor == target - numeroComIndice[i].valor
                    && x.indice != numeroComIndice[i].indice).FirstOrDefault();
                if (targetElement is not null)
                    return [numeroComIndice[i].indice, targetElement.indice];
            }
            return [];



        }
    }
}
