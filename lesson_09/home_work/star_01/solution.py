def setup_permissions(string):
    string = string.split()
    filename = string[0]
    permissions = string[1:]
    file_table[filename] = permissions
    
    
permission_table = {
    'execute': 'X',
    'read': 'R',
    'write': 'W'
    }

file_permissions = {}

for _ in range(int(input())):
    setup_permissions(input(), file_table)
    
for _ in range(int(input())):
    operation, file_name = input().split()
    if permission_table[operation] in file_permissions[file_name]:
        print('OK')
    else:
        print('Access denied')
