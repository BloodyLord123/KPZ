# 1. DRY
Уникнення дублювання коду. Логіка обробки грошей централізована в методі [SetMoney()](https://github.com/BloodyLord123/KPZ/blob/a015c2128df7ce9e6ae129a57d735e351dcdfaa8/lab1/Lab1/Money.cs#L23), що дозволяє її використовувати в різних частинах програми без повторів.
# 2. KISS
Програма зберігає простоту та зрозумілість. Кожен клас має чітке призначення. Клас [Money](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Money.cs) відповідає лише за операції з грошима, а клас [Product](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Product.cs) — за товар.
# 3. SOLID Принципи
3.1 SRP: Клас [Warehouse](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Warehouse.cs) працює з продуктами та їх транзакціями, а клас [Reporting](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Reporting.cs) генерує звіти.

3.2 OCP: Клас [Money](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Money.cs) можна розширювати без змін в існуючій логіці, дозволяючи додавати нові валюти чи конверсії.

3.3 LSP: Завдяки абстракціям, можна замінювати один тип об'єкта іншим без порушення роботи програми.

3.4 ISP: Кожен клас має лише необхідні методи, без зайвих залежностей.

3.5 DIP: Класи залежать від абстракцій, що дозволяє змінювати реалізації без зміни існуючого коду.
# 4. YAGNI 
У програмі реалізовані лише необхідні функціональності. Методи та класи виконують тільки те, що потрібно для поточних завдань. Наприклад, метод [ReducePrice()](https://github.com/BloodyLord123/KPZ/blob/a015c2128df7ce9e6ae129a57d735e351dcdfaa8/lab1/Lab1/Product.cs#L22) у класі [Product](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Product.cs) лише зменшує ціну.
# 5. Composition Over Inheritance
Використовується композиція, а не успадкування. У класі [Warehouse](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Warehouse.cs) комбінуються класи [Product](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Product.cs) і [Money](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Money.cs), що дозволяє легко змінювати чи додавати нові компоненти без необхідності змінювати існуючі.
# 6. Program to Interfaces, Not Implementations
Клас [Money](https://github.com/BloodyLord123/KPZ/blob/main/lab1/Lab1/Money.cs) реалізує інтерфейс для конвертації, що дозволяє працювати з різними типами валют та операціями без прямої прив'язки до конкретної реалізації.
# 7. Fail Fast
У методі [SetMoney()](https://github.com/BloodyLord123/KPZ/blob/a015c2128df7ce9e6ae129a57d735e351dcdfaa8/lab1/Lab1/Money.cs#L23), де перевіряється, чи не є значення від'ємними. Це дозволяє швидко виявляти помилки.
