def calculate_calibration_values(calibration_values):
    """Calculate the sum of calibration values from a list of strings.

    Each string contains digits, where the calibration value is determined by 
    combining the first and last digit (or the first digit twice if only one digit is present).

    Args:
    calibration_values: A list of strings representing calibration values.

    Returns:
    An integer representing the total sum of calibration values.
    """
    total_calibration_value = 0
    for value in calibration_values:
        digits = [int(char) for char in value if char.isdigit()]

        if digits:
            first_digit = last_digit = digits[0]
            if len(digits) > 1:
                last_digit = digits[-1]

            calibration_value_as_int = 10 * first_digit + last_digit
            total_calibration_value += calibration_value_as_int

    return total_calibration_value

def read_input(file_path):
    """Read calibration values from a file.

    Args:
    file_path: A string representing the path to the input file.

    Returns:
    A list of strings, each representing a line from the file.
    """
    try:
        with open(file_path, 'r') as file:
            return [line.strip() for line in file]
    except FileNotFoundError:
        raise Exception(f"File not found: {file_path}")

# Example usage
file_path = "E:\\Python\\adventofcode\\1.txt"
try:
    calibration_values = read_input(file_path)
    total_calibration_value = calculate_calibration_values(calibration_values)
    print("Total calibration value:", total_calibration_value)
except Exception as e:
    print(f"An error occurred: {e}")
