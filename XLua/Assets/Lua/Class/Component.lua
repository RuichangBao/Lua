local Object = require("Class.Object")
local Component = BaseClass(Object)

function Component:Tostring()
    return Object:Tostring() .. "Component.Tostring()"
end

-- function Component:

return Component
