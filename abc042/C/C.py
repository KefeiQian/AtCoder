import copy
import fractions
import math
import sys
from bisect import bisect_left, bisect_right
from collections import Counter, OrderedDict, defaultdict, deque
from functools import lru_cache, reduce
from heapq import heapify, heappop, heappush
from itertools import *


def LIST(): return sys.stdin.readline().split()
def INTEGER(): return int(sys.stdin.readline().rstrip())
def INTEGER_LIST(): return [int(x) for x in sys.stdin.readline().split()]
def ROWS(n): return [sys.stdin.readline().strip() for _ in range(n)]
def LIST_ROWS(n): return [LIST() for _ in range(n)]
def INTEGER_ROWS(n): return [INTEGER() for _ in range(n)]
def INTEGER_LIST_ROWS(n): return [INTEGER_LIST() for _ in range(n)]

def perm(n, r): return math.factorial(n) // math.factorial(r)
def comb(n, r): return math.factorial(n) // (math.factorial(r) * math.factorial(n-r))
def powerset(iterable):
    s = list(iterable)
    return chain.from_iterable(combinations(s, r) for r in range(len(s)+1))

def make_list(n, *args, default=0): return [make_list(*args, default=default) for _ in range(n)] if args else [default for _ in range(n)]

dire = [[1, 0], [0, 1], [-1, 0], [0, -1]]
dire8 = [[1, 0], [1, 1], [0, 1], [-1, 1], [-1, 0], [-1, -1], [0, -1], [1, -1]]
alphabets = "abcdefghijklmnopqrstuvwxyz"
ALPHABETS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
MOD = 1000000007
INF = float("inf")

sys.setrecursionlimit(1000000)

def main():
    N, _ = LIST()
    number_of_digits_of_N = len(N)

    dislike_numbers = set(INTEGER_LIST())
    like_numbers = []

    for i in range(10):
        if i not in dislike_numbers:
            like_numbers.append(str(i))

    # first we try a larger number with same number of digits    
    def generate_same_digits_number(p, is_larger_than_target):
        for i in like_numbers:
            if is_larger_than_target or i >= N[p]:
                if p == number_of_digits_of_N - 1:
                    return i

                next_position = generate_same_digits_number(p + 1, is_larger_than_target or i > N[p])
                if next_position:
                    return i + next_position
                
        return None

    res = generate_same_digits_number(0, False)

    #if we cannot find a number with same number of digits, then we generate a number with one more digit
    if not res:
        res = ""
        while len(res) <= number_of_digits_of_N:
            for i in like_numbers:
                if len(res) == 0 and i == "0":
                    continue

                res += i
                break
    
    print(res)


if __name__ == '__main__':
    main()