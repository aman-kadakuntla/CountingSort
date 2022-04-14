"# CountingSort" 

Counting Sort is one of the Sorting techniques. 

This code can only be used for sorting positive numbers. 

For negative numbers, there could be another solution.

==============================
Counting sort implementation
==============================
1. Given an array of positive elements
2. Find the maximum element in the given array. let it be maxElement.
3. Now, declare an array(countArray) of length (maxElement+1)
4. Count the frequency of each digit in the given array and update the countArray in the respective index.
     ex: if count of number 2 is 10, then the update countArray[2] as 10
6. Now Update the countArray as per following conditions:
      a. start from index 1
      b. the current element = current element + previous element
      c. repeat for all elements
7. Create a resultArray of size equal to input array
8. Now, from the input array, start from last element till 0th element and do the following.
      a. take the value of the current index. let it be val
      b. now decrease by 1 the value of the countArray at index val.
      c. take the decreased value of the countArray at index val as indx
      d. update the val in the result array at index indx
9. Finally, we get the sorted array.

Note: This implementation is applicable for an array containing only positive numbers.
