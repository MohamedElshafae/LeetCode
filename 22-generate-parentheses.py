class Solution(object):
    li = []
    def generateParenthesisRec(self, num, s, n):
        if num == 0:
            if self.isCompletePattern(s, n) == True:
                self.li.append(s)
            return
        self.generateParenthesisRec(num - 1, s + '(', n)
        self.generateParenthesisRec(num - 1, s + ')', n)

    def isCompletePattern(self, s , n):
        stack = []

        for ch in s:
            if ch == ')' and len(stack) == 0:
                return False
            elif ch == '(':
                stack.append('(')
            elif ch == ')':
                stack.pop()
        print(stack)
        if len(stack) == 0:
            return True
        return False
            
	
    def generateParenthesis(self, n):
        self.li = []
        if n == 1:
            return ['()']
        self.generateParenthesisRec((2 * n) - 1, '(', 2 * n)
        return self.li

