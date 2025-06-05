# Calculator API

REST API для калькулятора с основными арифметическими операциями и поддержкой сложных выражений.

---

## Общая информация

- Базовый URL: `https://localhost:7222/Calculator`
- Формат запросов: HTTP GET
- Параметры передаются в query string

---

## Эндпоинты

### 1. Сложение (Addition)
GET /Calculator/addition?firstInput={число}&secondInput={число}

### 2. Вычитание (Subtraction)
GET /Calculator/subtraction?firstInput={число}&secondInput={число}

### 3. Умножение (Multiplication)
GET /Calculator/multiplication?firstInput={число}&secondInput={число}

### 4. Деление (Division)
GET /Calculator/division?firstInput={число}&secondInput={число}

### 5. Возведение в степень (Power)
GET /Calculator/power?_base={число}&exponent={число}

### 6. Корень (Root)
GET /Calculator/root?value={число}&degree={число}

### 7. Сложное выражение (HardExpression)
GET /Calculator/hardExpression?expression={строка}

---

## Обработка ошибок
В случае ошибки возвращается HTTP 400 с сообщением об ошибке.
