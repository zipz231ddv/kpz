# Лабораторна робота 1

## Принципи програмування, використані в коді.

### 1. DRY
- Створено окремі класи
  [`Money`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class1.cs#L5),
  [`Product`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class2.cs#L5),
  [`Warehouse`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class3.cs#L7),
  [`Reporting`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class4.cs#L5),
- Окремі методи [`AddStock`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class2.cs#L38), [`RemoveStock`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class2.cs#L44).
- Спільна логіка обліку товару в [`Warehouse`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Class3.cs#L7)

### 2. KISS
- Простий Інтерфейс
- Немає складних структур
- Основний клас [`Program`](https://github.com/zipz231ddv/kpz/blob/main/kpz_lab_1/lab1/Program.cs#L5) легко читається.

### 3. YAGNI
- Немає зайвого функціоналу.
- Відсутні непотрібні абстрактні класи та інтерфейси.

### 4. SOLID
- Кожен клас виконує лише одну логічну функцію.
- Залежності прості.
