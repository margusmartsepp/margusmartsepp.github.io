import re

def find_substring_indices(text, substring):
    """Return the starting indices of all occurrences of substring in text.

    Args:
    text: A string in which to search for the substring.
    substring: A string representing the substring to find.

    Returns:
    A list of integers representing the starting indices of substring in text.
    """
    pattern = re.escape(substring)
    return [match.start() for match in re.finditer(pattern, text)]

def read_input(file_path):
  """Return the input as a list of lines from a file.

  Args:
  file_path: A string representing the path to the input file.

  Returns:
  A list of strings, each representing a line from the input file.
  """
  try:
    with open(file_path) as file:
      return file.read().splitlines()
  except FileNotFoundError:
    raise FileNotFoundError(f"File not found: {file_path}")

def solve_puzzle_part_two(file_path):
    """Solve the second part of the puzzle.

    Args:
    file_path: A string representing the path to the input file.

    Returns:
    An integer representing the sum of the first and last digits (or spelled-out digits) in each line of the file.
    """
    str_digit_map = {
        'one': '1', 'two': '2', 'three': '3', 'four': '4', 'five': '5',
        'six': '6', 'seven': '7', 'eight': '8', 'nine': '9'
    }
    str_digit_map.update({str(i): str(i) for i in range(1, 10)})

    total_sum = 0
    for line in read_input(file_path):
        findings = {}
        for s, v in str_digit_map.items():
            findings.update({i: v for i in find_substring_indices(line, s)})
        if findings:
            min_idx, max_idx = min(findings), max(findings)
            total_sum += int("".join((findings[min_idx], findings[max_idx])))

    return total_sum

# Usage
file_path = "E:\\Python\\adventofcode\\1.txt"
try:
    result = solve_puzzle_part_two(file_path)
    print("Result:", result)
except Exception as e:
    print(f"An error occurred: {e}")
