class Solution(object):
    def twoSum(self, nums, target):

        indices = []

        for i in range(len(nums)):

            num = target - nums[i]
            
            if(num in indices):
                victor = nums.index(num)

                return[victor,i]

            indices.append(nums[i])
