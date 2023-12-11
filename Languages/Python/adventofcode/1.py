def calculate_calibration_values(calibration_values):
    total_calibration_value = 0
    for calibration_value in calibration_values:
        # Extracting digits from the line
        digits = [char for char in calibration_value if char.isdigit()]

        # If the line has at least one digit
        if digits:
            # If there's only one digit, use it twice
            first_digit = last_digit = int(digits[0])
            if len(digits) > 1:
                last_digit = int(digits[-1])

            # Combining the first and last digit to form a two-digit number
            calibration_value_as_int = 10 * first_digit + last_digit

            # Adding the calibration value to the total sum
            total_calibration_value += calibration_value_as_int

    return total_calibration_value

# Read the calibration values from the file
calibration_values = []
with open("E:\\Python\\adventofcode\\1.txt", "r") as f:
    for line in f:
        calibration_values.append(line.strip())

# Calculate the sum of all calibration values
total_calibration_value = calculate_calibration_values(calibration_values)
print("Total calibration value:", total_calibration_value)
