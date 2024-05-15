//region Task1
// function compareNumbers(num1, num2) {
//     if (num1 < num2) {
//         return -1;
//     } else if (num1 > num2) {
//         return 1;
//     } else {
//         return 0;
//     }
// }
//endregion

//region Task2
// function factorial(n) {
//     if (n === 0 || n === 1) {
//         return 1;
//     } else {
//         return n * factorial(n - 1);
//     }
// }
//endregion

//region Task3
// function combineDigits(digit1, digit2, digit3) {
//     return parseInt(digit1.toString() + digit2.toString() + digit3.toString());
// }
//endregion

//region Task4
// function calculateArea(length, width) {
//     if (width === undefined) {
//         // Если передан только один параметр, считаем, что это длина стороны квадрата
//         return length * length; // Площадь квадрата
//     } else {
//         return length * width; // Площадь прямоугольника
//     }
// }
//endregion

//region Task5 & Task6
// function isPerfectNumber(number) {
//     let sum = 0;
//     for (let i = 1; i < number; i++) {
//         if (number % i === 0) {
//             sum += i;
//         }
//     }
//     return sum === number;
// }
//
// function perfectNumbersInRange(min, max) {
//     let perfectNumbers = [];
//     for (let i = min; i <= max; i++) {
//         if (isPerfectNumber(i)) {
//             perfectNumbers.push(i);
//         }
//     }
//     return perfectNumbers;
// }
//endregion

//region Task7
// function formatTime(hours, minutes, seconds) {
//     hours = hours < 10 ? '0' + hours : hours;
//     minutes = minutes !== undefined ? (minutes < 10 ? '0' + minutes : minutes) : '00';
//     seconds = seconds !== undefined ? (seconds < 10 ? '0' + seconds : seconds) : '00';
//     return hours + ':' + minutes + ':' + seconds;
// }
//endregion

//region Task8
// function timeToSeconds(hours, minutes, seconds) {
//     return hours * 3600 + minutes * 60 + seconds;
// }
//endregion

//region Task9
// function formatTimeFromSeconds(totalSeconds) {
//     let hours = totalSeconds // 3600;
//     let minutes = (totalSeconds % 3600) // 60;
//     let seconds = totalSeconds % 60;
//
//     let formattedHours = hours < 10 ? '0' + hours : hours;
//     let formattedMinutes = minutes < 10 ? '0' + minutes : minutes;
//     let formattedSeconds = seconds < 10 ? '0' + seconds : seconds;
//
//     return formattedHours + ':' + formattedMinutes + ':' + formattedSeconds;
// }
//endregion

//region Task10
// function timeToSeconds(hours, minutes, seconds) {
//     return hours * 3600 + minutes * 60 + seconds;
// }
//
// function timeDifference(startH, startM, startS, endH, endM, endS) {
//     var startSeconds = timeToSeconds(startH, startM, startS);
//     var endSeconds = timeToSeconds(endH, endM, endS);
//     return endSeconds - startSeconds;
// }
//
// function secondsToTime(seconds) {
//     var hours = Math.floor(seconds / 3600);
//     seconds %= 3600;
//     var minutes = Math.floor(seconds / 60);
//     seconds %= 60;
//     return hours.toString().padStart(2, '0') + ':' + minutes.toString().padStart(2, '0') + ':' + seconds.toString().padStart(2, '0');
// }
//
// function timeDifferenceString(startH, startM, startS, endH, endM, endS) {
//     var diffSeconds = timeDifference(startH, startM, startS, endH, endM, endS);
//     return secondsToTime(diffSeconds);
// }
//endregion