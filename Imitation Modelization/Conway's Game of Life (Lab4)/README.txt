Данг Фыонг Нам 932102

На dataGridView выбирать квадраты, чтобы их красить зелеными

Начинать/Останавливать программу кнопкой

Алгоритм:

Шаг1
При нажатии на квадрат (Координат этого квадрата добиваем в список listOfLivingCells)

Шаг2
Помечаем зеленые и их окружаюшие белые квадраты как "потенциальными" (добиваем в список potentialPoints)
//этот шаг для того, чтобы нам не придется просматривать все квадраты, а только "потенциалные". Так будет быстрее

Шаг3 
Применяем правило Игры "Жизни".Все значение сохряним в двумерном массиве gameBoard и воспомогательном массиве tempBoard из-за трудности работать с dataGridView.Cell.Style.BackColor.

