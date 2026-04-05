using System;
using System.Collections.Generic;

namespace AlgorithmsTheory_CP5
{
    class Node
    {
        public string Name;
        public int Day;
        public int Month;
        public bool IsDeleted; // потрібно для коректного видалення при лінійному зондуванні

        public Node(string name, int day, int month)
        {
            this.Name = name;
            this.Day = day;
            this.Month = month;
            this.IsDeleted = false;
        }
    }

    class LinearHashTable
    {
        private Node[] buckets;
        private int size = 101; // просте число, ~70 елементів / 0.7

        public LinearHashTable()
        {
            buckets = new Node[size];
        }

        private int Hash(int day, int month)
        {
            return (day * 37 + month) % size;
        }

        public string Add(string name, int day, int month)
        {
            int index = Hash(day, month);
            int startIndex = index;

            while (buckets[index] != null && !buckets[index].IsDeleted)
            {
                // перевірка на дублікат
                if (buckets[index].Day == day && buckets[index].Month == month && buckets[index].Name == name)
                    return "Вже існує!";

                index = (index + 1) % size;
                if (index == startIndex) return "Таблиця повна!";
            }

            buckets[index] = new Node(name, day, month);
            return $"Успішно! Розділ №{index}";
        }

        public string Remove(string name, int day, int month)
        {
            int index = Hash(day, month);
            int startIndex = index;

            while (buckets[index] != null)
            {
                if (!buckets[index].IsDeleted &&
                    buckets[index].Day == day &&
                    buckets[index].Month == month &&
                    buckets[index].Name == name)
                {
                    buckets[index].IsDeleted = true; // "ліниве" видалення
                    return $"Видалено з розділу №{index}";
                }

                index = (index + 1) % size;
                if (index == startIndex) break;
            }

            return "Не знайдено!";
        }

        public string Search(string name, int day, int month)
        {
            int index = Hash(day, month);
            int startIndex = index;

            while (buckets[index] != null)
            {
                if (!buckets[index].IsDeleted &&
                    buckets[index].Day == day &&
                    buckets[index].Month == month &&
                    buckets[index].Name == name)
                    return $"Знайдено в розділі №{index}";

                index = (index + 1) % size;
                if (index == startIndex) break;
            }

            return "Не знайдено!";
        }

        public List<string> GetTable()
        {
            List<string> rows = new List<string>();
            for (int i = 0; i < size; i++)
            {
                if (buckets[i] != null && !buckets[i].IsDeleted)
                    rows.Add($"Бакет {i}: [{buckets[i].Name} | {buckets[i].Day}.{buckets[i].Month:D2}]");
            }
            return rows;
        }
        public List<string> SearchByDate(int day, int month)
        {
            List<string> result = new List<string>();
            // для Linear — перебираємо весь масив buckets
            for (int i = 0; i < size; i++)
            {
                if (buckets[i] != null && !buckets[i].IsDeleted &&
                    buckets[i].Day == day && buckets[i].Month == month)
                {
                    result.Add($"[{buckets[i].Name} | {buckets[i].Day}.{buckets[i].Month:D2}]");
                }
            }
            return result;
        }
    }

    class CuckooHashTable
    {
        private Node[] table1;
        private Node[] table2;
        private int size = 101;

        public CuckooHashTable()
        {
            table1 = new Node[size];
            table2 = new Node[size];
        }

        private int Hash1(int day, int month)
        {
            return ((month - 1) * 31 + (day - 1)) % size;
        }

        private int Hash2(int day, int month)
        {
            return (day * 37 + month) % size;
        }

        public string Add(string name, int day, int month)
        {
            // перевірка чи вже існує
            if (Search(name, day, month) != "Не знайдено!")
                return "Вже існує!";

            Node newNode = new Node(name, day, month);
            int maxIterations = size;

            for (int i = 0; i < maxIterations; i++)
            {
                int index1 = Hash1(newNode.Day, newNode.Month);

                if (table1[index1] == null)
                {
                    table1[index1] = newNode;
                    return $"Успішно! Таблиця 1, розділ №{index1}";
                }

                // випихуємо з таблиці 1
                Node displaced = table1[index1];
                table1[index1] = newNode;
                newNode = displaced;

                int index2 = Hash2(newNode.Day, newNode.Month);

                if (table2[index2] == null)
                {
                    table2[index2] = newNode;
                    return $"Успішно! Таблиця 2, розділ №{index2}";
                }

                // випихуємо з таблиці 2
                displaced = table2[index2];
                table2[index2] = newNode;
                newNode = displaced;
            }

            return "Цикл! Потрібен рехешинг.";
        }

        public string Remove(string name, int day, int month)
        {
            int index1 = Hash1(day, month);
            if (table1[index1] != null &&
                table1[index1].Name == name &&
                table1[index1].Day == day &&
                table1[index1].Month == month)
            {
                table1[index1] = null;
                return $"Видалено з таблиці 1, розділ №{index1}";
            }

            int index2 = Hash2(day, month);
            if (table2[index2] != null &&
                table2[index2].Name == name &&
                table2[index2].Day == day &&
                table2[index2].Month == month)
            {
                table2[index2] = null;
                return $"Видалено з таблиці 2, розділ №{index2}";
            }

            return "Не знайдено!";
        }

        public string Search(string name, int day, int month)
        {
            int index1 = Hash1(day, month);
            if (table1[index1] != null &&
                table1[index1].Name == name &&
                table1[index1].Day == day &&
                table1[index1].Month == month)
                return $"Знайдено в таблиці 1, розділ №{index1}";

            int index2 = Hash2(day, month);
            if (table2[index2] != null &&
                table2[index2].Name == name &&
                table2[index2].Day == day &&
                table2[index2].Month == month)
                return $"Знайдено в таблиці 2, розділ №{index2}";

            return "Не знайдено!";
        }

        public List<string> GetTable()
        {
            List<string> rows = new List<string>();
            rows.Add("=== Таблиця 1 (Hash1) ===");
            for (int i = 0; i < size; i++)
                if (table1[i] != null)
                    rows.Add($"Бакет {i}: [{table1[i].Name} | {table1[i].Day}.{table1[i].Month:D2}]");

            rows.Add("=== Таблиця 2 (Hash2) ===");
            for (int i = 0; i < size; i++)
                if (table2[i] != null)
                    rows.Add($"Бакет {i}: [{table2[i].Name} | {table2[i].Day}.{table2[i].Month:D2}]");

            return rows;
        }
        public List<string> SearchByDate(int day, int month)
        {
            List<string> result = new List<string>();

            for (int i = 0; i < size; i++)
            {
                if (table1[i] != null &&
                    table1[i].Day == day &&
                    table1[i].Month == month)
                {
                    result.Add($"[{table1[i].Name} | {table1[i].Day}.{table1[i].Month:D2}]");
                }
            }

            for (int i = 0; i < size; i++)
            {
                if (table2[i] != null &&
                    table2[i].Day == day &&
                    table2[i].Month == month)
                {
                    result.Add($"[{table2[i].Name} | {table2[i].Day}.{table2[i].Month:D2}]");
                }
            }

            return result;
        }
    }
}