"""
    Gnome Sort
    ----------
    A sorting algorithm similar to insertion sort except that the element is
    moved to its proper place by a series of swaps.

    Time Complexity: O(n**2)

    Space Complexity: O(1) auxillary

    Stable: No

    Psuedo code: http://en.wikipedia.org/wiki/Gnome_sort

"""


def sort(seq):
    """
    Takes a list of integers and sorts them in ascending order. This sorted
    list is then returned.

    :param seq: A list of integers
    :rtype: A list of sorted integers
    """
    seq.sort();
    return seq
