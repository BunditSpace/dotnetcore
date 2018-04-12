using System;

namespace ClassLibraryISBN
{
    public class ISBN
    {
        /// <summary>
        /// Check ISBN is valid or Not  
        /// </summary>
        /// <param name="isbn10"> isbn number </param>
        /// <returns></returns>
        public bool IsValidISBN(string isbn10)
        {
            if (!string.IsNullOrEmpty(isbn10))
            {
                string isbn = ReplaceSpace(isbn10);
                isbn = ReplaceHypen(isbn);
                if(isbn.Length == 10)
                {
                    int sumEachDigit = CalculateSumEachDigit(isbn);
                    int checkDigit = GetCheckDigit(isbn);
                    int result = GetModuloResult(sumEachDigit);
                    if(checkDigit == result)
                        return true;
                }
            }

            return false;
        }

        private string ReplaceSpace(string isbn10)
        {
            return isbn10.Replace(" ", string.Empty);
        }

        private string ReplaceHypen(string isbn10)
        {
            return isbn10.Replace("-", string.Empty);
        }

        private int CalculateSumEachDigit(string isbn10)
        {
            int sum = 0;
            for (int i = 0; i < isbn10.Length - 1; i++)
            {
                int number = int.Parse(isbn10[i].ToString());
                int digit = i + 1;
                sum += number * digit;
            }

            return sum;
        }

        private int GetCheckDigit(string isbn10)
        {
            return int.Parse(isbn10.Substring(9, 1));
        }

        private int GetModuloResult(int sumEachDigit)
        {
            return sumEachDigit % 11;
        }
    }
}
