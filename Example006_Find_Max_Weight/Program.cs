int[] weight = {1, 2, 16, 8, 4};
int max = weight[0];
for (int i = 0; i < weight.Length; i++) 
{
  if (max < weight[i]) max = weight[i];
}
Console.WriteLine("Максимальный вес - " + max);