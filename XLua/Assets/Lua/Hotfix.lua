print("Hotfix Start")

xlua.hotfix(CS.Test, 'Print1', function(self)
    print('<<<<<<<<Update in lua, tick = ' )
end)

xlua.hotfix(CS.Test, 'Print2', function(self)
    print('<<<<<<<<Update in lua, tick = ' )
end)

print("Hotfix End")
