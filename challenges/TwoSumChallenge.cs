using System.Diagnostics;

namespace POC.LeetCodeTestApp.challenges
{
    public static class TwoSumChallenge
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            int[,] numeroComIndice2 = new int[nums.Length, 2];
            // Preenche o array bidimensional com índices e valores
            for (int i = 0; i < nums.Length; i++)
            {
                numeroComIndice2[i, 0] = i;       // índice
                numeroComIndice2[i, 1] = nums[i]; // valor
            }

            for (int i = 0; i < nums.Length; i++)
            {
                int targetElement2 = target - numeroComIndice2[i, 1];

                for (int j = 1; j < nums.Length; j++)
                {
                    if (j == i) continue;

                    if (targetElement2 == numeroComIndice2[j, 1])
                        return [numeroComIndice2[i, 0], numeroComIndice2[j, 0]];
                }
            }
            return [];
        }
        public static int[] TwoSum_UsingLinq(int[] nums, int target)
        {
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

        public static int[] TwoSum_UsingHash(int[] nums, int target)
        {
            //Gerado por IA
            // Dicionário para armazenar o valor e seu índice
            Dictionary<int, int> numIndices = [];

            // Itera sobre os elementos do array
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                // Verifica se o complemento já está no dicionário
                if (numIndices.ContainsKey(complement))
                {
                    return [numIndices[complement], i];
                }

                // Adiciona o valor atual e seu índice ao dicionário
                if (!numIndices.ContainsKey(nums[i]))
                {
                    numIndices.Add(nums[i], i);
                }
            }

            // Se não encontrar a solução, retorna um array vazio
            return [];
        }
    }
}
