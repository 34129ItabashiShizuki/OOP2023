using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScores(filePath);
        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new SortedDictionary<string, int>();
            foreach (var scores in _score) {
                if (dict.ContainsKey(scores.Subject))
                    dict[scores.Subject] += scores.Score; //科目名が既に存在する(点数加算)
                else
                    dict[scores.Subject] = scores.Score;  //科目名が存在しない(新規格納)
            }
            return dict;
        }

        //メソッドの概要： 
        private static IEnumerable<Student> ReadScores(string filePath) {

            var scores = new List<Student>();

            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines) {
                var items = line.Split(',');
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student);
            }
            return scores;

        }

    }
}
