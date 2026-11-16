
function add(x, y) {
    if (typeof x !== "number" || typeof y !== "number" ||
        !Number.isFinite(x) || !Number.isFinite(y)) {
        return "Ошибка: некорректные данные.";
    }
    if (x < 0 || y < 0) {
        return "Ошибка: отрицательные числа запрещены.";
    }
    return x + y;
}

function subtract(x, y) {
    if (typeof x !== "number" || typeof y !== "number" ||
        !Number.isFinite(x) || !Number.isFinite(y)) {
        return "Ошибка: некорректные данные.";
    }
    if (x < 0 || y < 0) {
        return "Ошибка: отрицательные числа запрещены.";
    }
    return x - y;
}

function multiply(x, y) {
    if (typeof x !== "number" || typeof y !== "number" ||
        !Number.isFinite(x) || !Number.isFinite(y)) {
        return "Ошибка: некорректные данные.";
    }
    if (x < 0 || y < 0) {
        return "Ошибка: отрицательные числа запрещены.";
    }
    return x * y;
}

function divide(x, y) {
    if (typeof x !== "number" || typeof y !== "number" ||
        !Number.isFinite(x) || !Number.isFinite(y)) {
        return "Ошибка: некорректные данные.";
    }
    if (x < 0 || y < 0) {
        return "Ошибка: отрицательные числа запрещены.";
    }
    if (y === 0) {
        return "Ошибка: деление на ноль невозможно.";
    }
    return x / y;
}

// Функцияларды тексеру
console.log("10 + 5 =", add(10, 5));
console.log("Қате қосу:", add("а", 5));

console.log("10 - 5 =", subtract(10, 5));
console.log("Қате азайту:", subtract(10, "б"));

console.log("10 * 5 =", multiply(10, 5));
console.log("Қате көбейту:", multiply("в", 5));

console.log("10 / 5 =", divide(10, 5));
console.log("Қате бөлу:", divide(10, "г"));
console.log("Нөлге бөлу:", divide(10, 0));
console.log("Теріс сан:", add(-5, 10));
